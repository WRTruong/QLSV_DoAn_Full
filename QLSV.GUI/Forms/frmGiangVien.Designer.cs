namespace QLSV.GUI
{
    partial class frmGiangVien
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DataGridView dgvGiangVien;
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dgvGiangVien = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.Text = "Họ Tên";
            this.lblHoTen.Location = new System.Drawing.Point(10, 20);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(100, 15);
            this.txtHoTen.Size = new System.Drawing.Size(200, 22);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Text = "Giới Tính";
            this.lblGioiTinh.Location = new System.Drawing.Point(10, 55);
            // 
            // rbNam
            // 
            this.rbNam.Text = "Nam";
            this.rbNam.Location = new System.Drawing.Point(100, 50);
            this.rbNam.Checked = true;
            // 
            // rbNu
            // 
            this.rbNu.Text = "Nữ";
            this.rbNu.Location = new System.Drawing.Point(170, 50);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Text = "Ngày Sinh";
            this.lblNgaySinh.Location = new System.Drawing.Point(10, 85);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(100, 80);
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
            // 
            // lblEmail
            // 
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new System.Drawing.Point(10, 115);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 110);
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            // 
            // lblSDT
            // 
            this.lblSDT.Text = "SDT";
            this.lblSDT.Location = new System.Drawing.Point(10, 145);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(100, 140);
            this.txtSDT.Size = new System.Drawing.Size(200, 22);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Text = "Địa Chỉ";
            this.lblDiaChi.Location = new System.Drawing.Point(10, 175);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(100, 170);
            this.txtDiaChi.Size = new System.Drawing.Size(200, 22);
            // 
            // dgvGiangVien
            // 
            this.dgvGiangVien.Location = new System.Drawing.Point(320, 15);
            this.dgvGiangVien.Size = new System.Drawing.Size(400, 200);
            this.dgvGiangVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiangVien.AutoGenerateColumns = false;
            this.dgvGiangVien.SelectionChanged += new System.EventHandler(this.dgvGiangVien_SelectionChanged);
            // 
            // btnThem
            // 
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(10, 210);
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(100, 210);
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(190, 210);
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(280, 210);
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmGiangVien
            // 
            this.ClientSize = new System.Drawing.Size(740, 260);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.rbNu);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.dgvGiangVien);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnRefresh);
            this.Text = "Quản lý Giảng Viên";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
