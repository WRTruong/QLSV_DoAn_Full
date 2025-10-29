using System;
using System.Linq;
using System.Windows.Forms;
using QLSV.BUS.Services; 

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
                // Kiểm tra quyền, mở form tương ứng
                if (tk.Quyen.Any(q => q.TenQuyen == "SinhVien"))
                {
                    new frmSVHome(tk).Show(); // Form sinh viên
                }
                else
                {
                    new frmMain(tk).Show(); // Form Admin/GV
                }
                this.Hide();
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
