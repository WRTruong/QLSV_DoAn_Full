namespace QLSV.GUI
{
    partial class frmSinhVien
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblLop = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.lblNgaySinh);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.lblLop);
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblSDT);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.lblDiaChi);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.picHinhAnh);
            this.groupBox1.Controls.Add(this.btnChonAnh);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Size = new System.Drawing.Size(400, 350);
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // lblHoTen
            // 
            this.lblHoTen.Text = "Họ tên";
            this.lblHoTen.Location = new System.Drawing.Point(10, 30);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(120, 25);
            this.txtHoTen.Size = new System.Drawing.Size(200, 22);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Text = "Ngày sinh";
            this.lblNgaySinh.Location = new System.Drawing.Point(10, 65);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(120, 60);
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
            // 
            // lblLop
            // 
            this.lblLop.Text = "Lớp";
            this.lblLop.Location = new System.Drawing.Point(10, 100);
            // 
            // cboLop
            // 
            this.cboLop.Location = new System.Drawing.Point(120, 95);
            this.cboLop.Size = new System.Drawing.Size(200, 24);
            // 
            // lblEmail
            // 
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new System.Drawing.Point(10, 135);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 130);
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            // 
            // lblSDT
            // 
            this.lblSDT.Text = "SĐT";
            this.lblSDT.Location = new System.Drawing.Point(10, 170);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(120, 165);
            this.txtSDT.Size = new System.Drawing.Size(200, 22);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Text = "Địa chỉ";
            this.lblDiaChi.Location = new System.Drawing.Point(10, 205);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(120, 200);
            this.txtDiaChi.Size = new System.Drawing.Size(200, 22);
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.Location = new System.Drawing.Point(250, 25);
            this.picHinhAnh.Size = new System.Drawing.Size(120, 120);
            this.picHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.Location = new System.Drawing.Point(250, 150);
            this.btnChonAnh.Size = new System.Drawing.Size(80, 25);
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.Location = new System.Drawing.Point(420, 10);
            this.dgvSinhVien.Size = new System.Drawing.Size(460, 350);
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.AutoGenerateColumns = false;
            // 
            // btnThem
            // 
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(10, 370);
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(110, 370);
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(210, 370);
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(310, 370);
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmSinhVien
            // 
            this.ClientSize = new System.Drawing.Size(900, 420);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnRefresh);
            this.Text = "Quản lý Sinh Viên";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
