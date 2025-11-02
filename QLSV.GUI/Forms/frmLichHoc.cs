using System;
using System.Linq;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL;

namespace QLSV.GUI
{
    public partial class frmLichHoc : Form
    {
        private readonly LichHocService lhService = new LichHocService();
        private readonly LopService lopService = new LopService();
        private readonly MonHocService mhService = new MonHocService();
        private readonly GiangVienService gvService = new GiangVienService();
        private readonly HocKyService hkService = new HocKyService();

        public frmLichHoc()
        {
            InitializeComponent();
            LoadCombos();
            LoadData();
            dgvLichHoc.SelectionChanged += DgvLichHoc_SelectionChanged;
        }

        private void LoadCombos()
        {
            cboLop.DataSource = lopService.GetAll();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";

            cboMonHoc.DataSource = mhService.GetAll();
            cboMonHoc.DisplayMember = "TenMH";
            cboMonHoc.ValueMember = "MaMH";

            cboGiangVien.DataSource = gvService.GetAll();
            cboGiangVien.DisplayMember = "HoTen";
            cboGiangVien.ValueMember = "MaGV";

            cboHocKy.DataSource = hkService.GetAll();
            cboHocKy.DisplayMember = "TenHK";
            cboHocKy.ValueMember = "MaHK";
        }

        private void LoadData()
        {
            dgvLichHoc.DataSource = null;
            var data = lhService.GetAll()
                .Select(lh => new
                {
                    lh.MaLop,
                    TenLop = lh.Lop?.TenLop ?? "",
                    lh.MaMH,
                    TenMH = lh.MonHoc?.TenMH ?? "",
                    lh.MaGV,
                    TenGV = lh.GiangVien?.HoTen ?? "",
                    lh.MaHK,
                    TenHK = lh.HocKy?.TenHK ?? "",
                    lh.Thu,
                    lh.TietBatDau,
                    lh.SoTiet
                }).ToList();

            dgvLichHoc.DataSource = data;
        }

        private void DgvLichHoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLichHoc.CurrentRow == null) return;

            var row = dgvLichHoc.CurrentRow;

            cboLop.SelectedValue = row.Cells["MaLop"].Value;
            cboMonHoc.SelectedValue = row.Cells["MaMH"].Value;
            cboGiangVien.SelectedValue = row.Cells["MaGV"].Value;
            cboHocKy.SelectedValue = row.Cells["MaHK"].Value;

            txtThu.Text = row.Cells["Thu"].Value?.ToString() ?? "";
            txtTietBD.Text = row.Cells["TietBatDau"].Value?.ToString() ?? "";
            txtSoTiet.Text = row.Cells["SoTiet"].Value?.ToString() ?? "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTietBD.Text, out int tietBD) || !int.TryParse(txtSoTiet.Text, out int soTiet))
            {
                MessageBox.Show("Tiết bắt đầu và Số tiết phải là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lh = new LichHoc
            {
                MaLop = Convert.ToInt32(cboLop.SelectedValue),
                MaMH = Convert.ToInt32(cboMonHoc.SelectedValue),
                MaGV = Convert.ToInt32(cboGiangVien.SelectedValue),
                MaHK = Convert.ToInt32(cboHocKy.SelectedValue),
                Thu = txtThu.Text,
                TietBatDau = tietBD,
                SoTiet = soTiet
            };

            if (lhService.Add(lh))
            {
                MessageBox.Show("Thêm lịch học thành công!");
                LoadData();
            }
            else MessageBox.Show("Thất bại!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLichHoc.CurrentRow == null) return;

            int maLop = Convert.ToInt32(dgvLichHoc.CurrentRow.Cells["MaLop"].Value);
            int maMH = Convert.ToInt32(dgvLichHoc.CurrentRow.Cells["MaMH"].Value);
            int maHK = Convert.ToInt32(dgvLichHoc.CurrentRow.Cells["MaHK"].Value);

            if (lhService.Delete(maLop, maMH, maHK))
            {
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
            else MessageBox.Show("Xóa thất bại!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
