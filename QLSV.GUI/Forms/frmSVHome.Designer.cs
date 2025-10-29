namespace QLSV.GUI
{
    partial class frmSVHome
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCaNhan;
        private System.Windows.Forms.TabPage tabLichHoc;
        private System.Windows.Forms.TabPage tabDangKyHoc;
        private System.Windows.Forms.TabPage tabDiem;
        private System.Windows.Forms.TextBox txtHoTen, txtDiaChi, txtEmail, txtSDT, txtQueQuan;
        private System.Windows.Forms.PictureBox pbHinhAnh;
        private System.Windows.Forms.Button btnCapNhat, btnDangKyMon;
        private System.Windows.Forms.DataGridView dgvLichHoc, dgvMonHoc, dgvDiem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCaNhan = new System.Windows.Forms.TabPage();
            this.tabLichHoc = new System.Windows.Forms.TabPage();
            this.tabDangKyHoc = new System.Windows.Forms.TabPage();
            this.tabDiem = new System.Windows.Forms.TabPage();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.pbHinhAnh = new System.Windows.Forms.PictureBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnDangKyMon = new System.Windows.Forms.Button();
            this.dgvLichHoc = new System.Windows.Forms.DataGridView();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.dgvDiem = new System.Windows.Forms.DataGridView();

            // TabControl
            this.tabControl1.Controls.Add(this.tabCaNhan);
            this.tabControl1.Controls.Add(this.tabLichHoc);
            this.tabControl1.Controls.Add(this.tabDangKyHoc);
            this.tabControl1.Controls.Add(this.tabDiem);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;

            // Tab CaNhan
            this.tabCaNhan.Text = "Thông tin cá nhân";
            this.tabCaNhan.Controls.Add(this.txtHoTen);
            this.tabCaNhan.Controls.Add(this.txtDiaChi);
            this.tabCaNhan.Controls.Add(this.txtEmail);
            this.tabCaNhan.Controls.Add(this.txtSDT);
            this.tabCaNhan.Controls.Add(this.txtQueQuan);
            this.tabCaNhan.Controls.Add(this.pbHinhAnh);
            this.tabCaNhan.Controls.Add(this.btnCapNhat);

            // Tab LichHoc
            this.tabLichHoc.Text = "Lịch học";
            this.tabLichHoc.Controls.Add(this.dgvLichHoc);
            this.dgvLichHoc.Dock = System.Windows.Forms.DockStyle.Fill;

            // Tab DangKyHoc
            this.tabDangKyHoc.Text = "Đăng ký môn học";
            this.tabDangKyHoc.Controls.Add(this.dgvMonHoc);
            this.tabDangKyHoc.Controls.Add(this.btnDangKyMon);
            this.dgvMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMonHoc.Height = 300;

            // Tab Diem
            this.tabDiem.Text = "Xem điểm";
            this.tabDiem.Controls.Add(this.dgvDiem);
            this.dgvDiem.Dock = System.Windows.Forms.DockStyle.Fill;

            // Form
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.tabControl1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang sinh viên";
            this.Load += new System.EventHandler(this.frmSVHome_Load);
        }
    }
}
