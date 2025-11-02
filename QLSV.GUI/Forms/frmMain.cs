using System;
using System.Linq;
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
            // ✅ Dùng loại tài khoản để xác định vai trò thực ("Admin" / "GiangVien" / "SinhVien")
            string role = tk.LoaiTK;

            if (tk.MaSV.HasValue)
            {
                // Sinh viên đăng ký
                new frmDangKyHoc(role, tk.MaSV.Value).ShowDialog();
            }
            else
            {
                // Admin hoặc giảng viên
                new frmDangKyHoc(role, 0).ShowDialog();
            }
        }




        private void menuDiem_Click(object sender, EventArgs e)
        {
            string role = tk.LoaiTK;

            if (role == "Admin")
            {
                new frmDiem("Admin").ShowDialog();
            }
            else if (role == "GiangVien" && tk.MaGV.HasValue)
            {
                // Giảng viên: truyền role và MaGV
                new frmDiem("GiangVien", null, tk.MaGV.Value).ShowDialog();
            }
            else if (role == "SinhVien" && tk.MaSV.HasValue)
            {
                // Sinh viên: truyền role và MaSV
                new frmDiem("SinhVien", tk.MaSV.Value).ShowDialog();
            }
        }


        private void menuThongBao_Click(object sender, EventArgs e)
        {
            string role = tk.LoaiTK;
            if (role == "GiangVien" && tk.MaGV.HasValue)
                new frmThongBao(role, null, tk.MaGV.Value).ShowDialog();
            else if (role == "SinhVien" && tk.MaSV.HasValue)
                new frmThongBao(role, tk.MaSV.Value).ShowDialog();
            else
                new frmThongBao(role).ShowDialog(); // Admin
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
        

        private void frmMain_Load(object sender, EventArgs e)
        {
            string role = tk.LoaiTK?.Trim();
            MessageBox.Show($"Username: {tk.Username}\nRole: {role}");

            // Ẩn menu mặc định
            menuKhoa.Visible = menuLop.Visible = menuGiangVien.Visible = menuMonHoc.Visible = menuSinhVien.Visible = false;
            menuDangKyHoc.Visible = menuDiem.Visible = menuHocKy.Visible = menuLichHoc.Visible = menuThongBao.Visible = false;

            if (role == "Admin")
            {
                menuKhoa.Visible = menuLop.Visible = menuGiangVien.Visible = menuMonHoc.Visible = menuSinhVien.Visible = true;
                menuDangKyHoc.Visible = menuDiem.Visible = menuHocKy.Visible = menuLichHoc.Visible = menuThongBao.Visible = true;
            }
            else if (role == "GiangVien")
            {
                menuDangKyHoc.Visible = false;
                menuDiem.Visible = true;
                menuThongBao.Visible = true;
                menuLichHoc.Visible = true;
            }
            else if (role == "SinhVien")
            {
                menuDangKyHoc.Visible = true;
                menuDiem.Visible = true;
                menuThongBao.Visible = true;
                menuLichHoc.Visible = true;
            }
        }

    }
}
