using System;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL;

namespace QLSV.GUI
{
    public partial class frmDangNhap : Form
    {
        private readonly TaiKhoanService tkService = new TaiKhoanService();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Username và Password", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tk = tkService.DangNhap(username, password);

            if (tk != null)
            {
                // Sử dụng LoaiTK để phân biệt sinh viên hay GV/Admin
                if (tk.LoaiTK == "SinhVien")
                {
                    // Mở form sinh viên
                    frmSVHome svHome = new frmSVHome(tk);
                    svHome.Show();
                }
                else
                {
                    // Mở form Admin/GV
                    frmMain main = new frmMain(tk);
                    main.Show();
                }

                this.Hide(); // Ẩn form đăng nhập
            }
            else
            {
                MessageBox.Show("Sai Username hoặc Password!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
