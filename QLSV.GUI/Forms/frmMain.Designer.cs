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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGiangVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangKyHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongBao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHocKy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLichHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.menuThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1092, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuKhoa
            // 
            this.menuKhoa.Name = "menuKhoa";
            this.menuKhoa.Size = new System.Drawing.Size(88, 36);
            this.menuKhoa.Text = "Khoa";
            this.menuKhoa.Click += new System.EventHandler(this.menuKhoa_Click);
            // 
            // menuLop
            // 
            this.menuLop.Name = "menuLop";
            this.menuLop.Size = new System.Drawing.Size(73, 36);
            this.menuLop.Text = "Lớp";
            this.menuLop.Click += new System.EventHandler(this.menuLop_Click);
            // 
            // menuGiangVien
            // 
            this.menuGiangVien.Name = "menuGiangVien";
            this.menuGiangVien.Size = new System.Drawing.Size(148, 36);
            this.menuGiangVien.Text = "Giảng viên";
            this.menuGiangVien.Click += new System.EventHandler(this.menuGiangVien_Click);
            // 
            // menuMonHoc
            // 
            this.menuMonHoc.Name = "menuMonHoc";
            this.menuMonHoc.Size = new System.Drawing.Size(130, 36);
            this.menuMonHoc.Text = "Môn học";
            this.menuMonHoc.Click += new System.EventHandler(this.menuMonHoc_Click);
            // 
            // menuSinhVien
            // 
            this.menuSinhVien.Name = "menuSinhVien";
            this.menuSinhVien.Size = new System.Drawing.Size(133, 36);
            this.menuSinhVien.Text = "Sinh viên";
            this.menuSinhVien.Click += new System.EventHandler(this.menuSinhVien_Click);
            // 
            // menuDangKyHoc
            // 
            this.menuDangKyHoc.Name = "menuDangKyHoc";
            this.menuDangKyHoc.Size = new System.Drawing.Size(168, 36);
            this.menuDangKyHoc.Text = "Đăng ký học";
            this.menuDangKyHoc.Click += new System.EventHandler(this.menuDangKyHoc_Click);
            // 
            // menuDiem
            // 
            this.menuDiem.Name = "menuDiem";
            this.menuDiem.Size = new System.Drawing.Size(91, 36);
            this.menuDiem.Text = "Điểm";
            this.menuDiem.Click += new System.EventHandler(this.menuDiem_Click);
            // 
            // menuThongBao
            // 
            this.menuThongBao.Name = "menuThongBao";
            this.menuThongBao.Size = new System.Drawing.Size(150, 36);
            this.menuThongBao.Text = "Thông báo";
            this.menuThongBao.Click += new System.EventHandler(this.menuThongBao_Click);
            // 
            // menuHocKy
            // 
            this.menuHocKy.Name = "menuHocKy";
            this.menuHocKy.Size = new System.Drawing.Size(107, 36);
            this.menuHocKy.Text = "Học kỳ";
            this.menuHocKy.Click += new System.EventHandler(this.menuHocKy_Click);
            // 
            // menuLichHoc
            // 
            this.menuLichHoc.Name = "menuLichHoc";
            this.menuLichHoc.Size = new System.Drawing.Size(122, 36);
            this.menuLichHoc.Text = "Lịch học";
            this.menuLichHoc.Click += new System.EventHandler(this.menuLichHoc_Click);
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(143, 36);
            this.menuDangXuat.Text = "Đăng xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);
            // 
            // menuThoat
            // 
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(95, 36);
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(20, 40);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(165, 25);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Xin chào: [User]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1092, 782);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(1092, 782);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Quản lý sinh viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private PictureBox pictureBox1;
    }
}
