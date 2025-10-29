using System;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL;

namespace QLSV.GUI
{
    public partial class frmDangKyHoc : Form
    {
        private readonly DangKyHocService dkService = new DangKyHocService();
        private readonly SinhVienService svService = new SinhVienService();
        private readonly MonHocService mhService = new MonHocService();

        private int currentMaSV; // Mã sinh viên đăng nhập

        public frmDangKyHoc(int maSV)
        {
            InitializeComponent();
            currentMaSV = maSV;
            LoadComboBox();
            LoadData();
        }

        private void LoadComboBox()
        {
            cboMonHoc.DataSource = mhService.GetAll();
            cboMonHoc.DisplayMember = "TenMH";
            cboMonHoc.ValueMember = "MaMH";
        }

        private void LoadData()
        {
            dgvDangKy.DataSource = null;
            dgvDangKy.DataSource = dkService.GetBySinhVien(currentMaSV);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            int maMH = (int)cboMonHoc.SelectedValue;
            if (dkService.DangKyMonHoc(currentMaSV, maMH))
            {
                MessageBox.Show("Đăng ký thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Bạn đã đăng ký môn này hoặc có lỗi!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dgvDangKy.CurrentRow == null) return;

            int maMH = (int)dgvDangKy.CurrentRow.Cells["MaMH"].Value;
            int maHK = (int)dgvDangKy.CurrentRow.Cells["MaHK"].Value;

            if (dkService.HuyDangKy(currentMaSV, maMH, maHK))
            {
                MessageBox.Show("Hủy đăng ký thành công!");
                LoadData();
            }
            else MessageBox.Show("Hủy thất bại!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
