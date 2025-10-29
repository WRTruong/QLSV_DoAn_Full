using System.Windows.Forms;

namespace QLSV.GUI
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuKhoa;
        private ToolStripMenuItem menuLop;
        private ToolStripMenuItem menuGiangVien;
        private ToolStripMenuItem menuMonHoc;
        private ToolStripMenuItem menuSinhVien;
        private ToolStripMenuItem menuDangKyHoc;
        private ToolStripMenuItem menuDiem;
        private ToolStripMenuItem menuThongBao;
        private ToolStripMenuItem menuHocKy;
        private ToolStripMenuItem menuLichHoc;
        private ToolStripMenuItem menuDangXuat;
        private ToolStripMenuItem menuThoat;
        private Label lblWelcome;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new MenuStrip();
            this.menuKhoa = new ToolStripMenuItem();
            this.menuLop = new ToolStripMenuItem();
            this.menuGiangVien = new ToolStripMenuItem();
            this.menuMonHoc = new ToolStripMenuItem();
            this.menuSinhVien = new ToolStripMenuItem();
            this.menuDangKyHoc = new ToolStripMenuItem();
            this.menuDiem = new ToolStripMenuItem();
            this.menuThongBao = new ToolStripMenuItem();
            this.menuHocKy = new ToolStripMenuItem();
            this.menuLichHoc = new ToolStripMenuItem();
            this.menuDangXuat = new ToolStripMenuItem();
            this.menuThoat = new ToolStripMenuItem();
            this.lblWelcome = new Label();

            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
                this.menuKhoa,
                this.menuLop,
                this.menuGiangVien,
                this.menuMonHoc,
                this.menuSinhVien,
                this.menuDangKyHoc,
                this.menuDiem,
                this.menuThongBao,
                this.menuHocKy,
                this.menuLichHoc,
                this.menuDangXuat,
                this.menuThoat
            });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // Menu items
            this.menuKhoa.Text = "Khoa";
            this.menuKhoa.Click += new System.EventHandler(this.menuKhoa_Click);

            this.menuLop.Text = "Lớp";
            this.menuLop.Click += new System.EventHandler(this.menuLop_Click);

            this.menuGiangVien.Text = "Giảng viên";
            this.menuGiangVien.Click += new System.EventHandler(this.menuGiangVien_Click);

            this.menuMonHoc.Text = "Môn học";
            this.menuMonHoc.Click += new System.EventHandler(this.menuMonHoc_Click);

            this.menuSinhVien.Text = "Sinh viên";
            this.menuSinhVien.Click += new System.EventHandler(this.menuSinhVien_Click);

            this.menuDangKyHoc.Text = "Đăng ký học";
            this.menuDangKyHoc.Click += new System.EventHandler(this.menuDangKyHoc_Click);

            this.menuDiem.Text = "Điểm";
            this.menuDiem.Click += new System.EventHandler(this.menuDiem_Click);

            this.menuThongBao.Text = "Thông báo";
            this.menuThongBao.Click += new System.EventHandler(this.menuThongBao_Click);

            this.menuHocKy.Text = "Học kỳ";
            this.menuHocKy.Click += new System.EventHandler(this.menuHocKy_Click);

            this.menuLichHoc.Text = "Lịch học";
            this.menuLichHoc.Click += new System.EventHandler(this.menuLichHoc_Click);

            this.menuDangXuat.Text = "Đăng xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);

            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);

            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(20, 40);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(120, 17);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Xin chào: [User]";

            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Quản lý sinh viên";
        }
    }
}
