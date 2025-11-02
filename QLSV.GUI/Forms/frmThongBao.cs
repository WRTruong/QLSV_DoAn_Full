using System;
using System.Linq;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL;

namespace QLSV.GUI
{
    public partial class frmThongBao : Form
    {
        private readonly ThongBaoService tbService = new ThongBaoService();
        private readonly LopService lopService = new LopService();
        private readonly SinhVienService svService = new SinhVienService();
        private readonly string role;
        private readonly int? maGV; // nếu là giảng viên, lưu MaGV

        public frmThongBao(string role, int? maSV = null, int? maGV = null)
        {
            InitializeComponent();
            this.role = role;
            this.maGV = maGV;

            LoadComboBoxes();
            LoadData();

            dgvThongBao.SelectionChanged += dgvThongBao_SelectionChanged;
            cboLop.SelectedIndexChanged += cboLop_SelectedIndexChanged;
        }

        private void LoadComboBoxes()
        {
            // Nếu là giảng viên, chỉ lấy lớp của họ
            if (role == "GiangVien" && maGV.HasValue)
            {
                cboLop.DataSource = lopService.GetByGiangVien(maGV.Value);
            }
            else
            {
                cboLop.DataSource = lopService.GetAll();
            }

            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboLop.SelectedIndex = -1;

            // Sinh viên
            cboSinhVien.DataSource = svService.GetAll();
            cboSinhVien.DisplayMember = "HoTen";
            cboSinhVien.ValueMember = "MaSV";
            cboSinhVien.SelectedIndex = -1;
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLop.SelectedIndex == -1)
            {
                cboSinhVien.DataSource = svService.GetAll();
            }
            else
            {
                int maLop = (int)cboLop.SelectedValue;
                cboSinhVien.DataSource = svService.GetByLop(maLop);
            }

            cboSinhVien.DisplayMember = "HoTen";
            cboSinhVien.ValueMember = "MaSV";
            cboSinhVien.SelectedIndex = -1;
        }

        private void LoadData()
        {
            dgvThongBao.DataSource = null;
            var data = tbService.GetAll();

            // Nếu là giảng viên, chỉ hiển thị thông báo của lớp họ dạy
            if (role == "GiangVien" && maGV.HasValue)
            {
                var lopGV = lopService.GetByGiangVien(maGV.Value).Select(l => l.MaLop).ToList();
                data = data.Where(tb => tb.MaLop != null && lopGV.Contains(tb.MaLop.Value)).ToList();
            }

            dgvThongBao.DataSource = data.Select(tb => new
            {
                tb.MaTB,
                tb.TieuDe,
                tb.NoiDung,
                NgayTB = tb.NgayTB?.ToString("dd/MM/yyyy HH:mm"),
                TenLop = tb.Lop != null ? tb.Lop.TenLop : "",
                TenSV = tb.SinhVien != null ? tb.SinhVien.HoTen : ""
            }).ToList();
        }

        private void dgvThongBao_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThongBao.CurrentRow == null) return;
            int maTB = (int)dgvThongBao.CurrentRow.Cells["MaTB"].Value;
            var tb = tbService.GetById(maTB);
            if (tb == null) return;

            txtTieuDe.Text = tb.TieuDe;
            txtNoiDung.Text = tb.NoiDung;

            cboLop.SelectedValue = tb.MaLop ?? -1;
            cboSinhVien.SelectedValue = tb.MaSV ?? -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTieuDe.Text) || string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập tiêu đề và nội dung!");
                return;
            }

            var tb = new ThongBao
            {
                TieuDe = txtTieuDe.Text,
                NoiDung = txtNoiDung.Text,
                NgayTB = DateTime.Now,
                MaLop = cboLop.SelectedIndex != -1 ? (int?)cboLop.SelectedValue : null,
                MaSV = cboSinhVien.SelectedIndex != -1 ? (int?)cboSinhVien.SelectedValue : null
            };

            if (tbService.Add(tb))
            {
                MessageBox.Show("Thêm thông báo thành công!");
                btnRefresh_Click(null, null);
            }
            else
                MessageBox.Show("Thêm thất bại!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvThongBao.CurrentRow == null) return;
            int maTB = (int)dgvThongBao.CurrentRow.Cells["MaTB"].Value;
            if (tbService.Delete(maTB))
            {
                MessageBox.Show("Xóa thành công!");
                btnRefresh_Click(null, null);
            }
            else
                MessageBox.Show("Xóa thất bại!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtTieuDe.Clear();
            txtNoiDung.Clear();
            cboLop.SelectedIndex = -1;
            cboSinhVien.SelectedIndex = -1;
            LoadData();
        }
    }
}
