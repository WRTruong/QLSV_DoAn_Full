using System;
using System.Drawing;
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
            dgvLichHoc.DataSource = lhService.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // kiểm tra và parse TietBatDau
            if (!int.TryParse(txtTietBD.Text, out int tietBD))
            {
                MessageBox.Show("Tiết bắt đầu phải là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtSoTiet.Text, out int soTiet))
            {
                MessageBox.Show("Số tiết phải là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lh = new LichHoc
            {
                MaLop = Convert.ToInt32(cboLop.SelectedValue),
                MaMH = Convert.ToInt32(cboMonHoc.SelectedValue),
                MaGV = Convert.ToInt32(cboGiangVien.SelectedValue),
                MaHK = Convert.ToInt32(cboHocKy.SelectedValue),
                Thu = txtThu.Text,  // nếu Thu là string thì ok
                TietBatDau = tietBD, // dùng giá trị đã parse
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

            int maLop = (int)dgvLichHoc.CurrentRow.Cells["MaLop"].Value;
            int maMH = (int)dgvLichHoc.CurrentRow.Cells["MaMH"].Value;
            int maHK = (int)dgvLichHoc.CurrentRow.Cells["MaHK"].Value;

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
