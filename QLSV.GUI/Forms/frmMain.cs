using System;
using System.Windows.Forms;
using QLSV.DAL;
using QLSV.GUI;

namespace QLSV.GUI
{
    public partial class frmMain : Form
    {
        private TaiKhoan tk;

        public frmMain(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            tk = taiKhoan;
            lblWelcome.Text = "Xin chào: " + tk.Username;
        }

        // Menu click mở các form quản lý
        private void menuKhoa_Click(object sender, EventArgs e)
        {
            new frmKhoa().ShowDialog();
        }

        private void menuLop_Click(object sender, EventArgs e)
        {
            new frmLop().ShowDialog();
        }

        private void menuGiangVien_Click(object sender, EventArgs e)
        {
            new frmGiangVien().ShowDialog();
        }

        private void menuMonHoc_Click(object sender, EventArgs e)
        {
            new frmMonHoc().ShowDialog();
        }

        private void menuSinhVien_Click(object sender, EventArgs e)
        {
            new frmSinhVien().ShowDialog();
        }

        private void menuDangKyHoc_Click(object sender, EventArgs e)
        {
            new frmDangKyHoc(0).ShowDialog(); // truyền mã SV nếu muốn
        }

        private void menuDiem_Click(object sender, EventArgs e)
        {
            new frmDiem().ShowDialog();
        }

        private void menuThongBao_Click(object sender, EventArgs e)
        {
            new frmThongBao().ShowDialog();
        }

        private void menuHocKy_Click(object sender, EventArgs e)
        {
            new frmHocKy().ShowDialog();
        }

        private void menuLichHoc_Click(object sender, EventArgs e)
        {
            new frmLichHoc().ShowDialog();
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmDangNhap().Show();
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
