namespace QLSV.GUI
{
    partial class frmLichHoc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblLop, lblMonHoc, lblGiangVien, lblHocKy, lblThu, lblTietBD, lblSoTiet;
        private System.Windows.Forms.ComboBox cboLop, cboMonHoc, cboGiangVien, cboHocKy;
        private System.Windows.Forms.TextBox txtThu, txtTietBD, txtSoTiet;
        private System.Windows.Forms.DataGridView dgvLichHoc;
        private System.Windows.Forms.Button btnThem, btnXoa, btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblLop = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.lblGiangVien = new System.Windows.Forms.Label();
            this.cboGiangVien = new System.Windows.Forms.ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.lblThu = new System.Windows.Forms.Label();
            this.txtThu = new System.Windows.Forms.TextBox();
            this.lblTietBD = new System.Windows.Forms.Label();
            this.txtTietBD = new System.Windows.Forms.TextBox();
            this.lblSoTiet = new System.Windows.Forms.Label();
            this.txtSoTiet = new System.Windows.Forms.TextBox();
            this.dgvLichHoc = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLop
            // 
            this.lblLop.Location = new System.Drawing.Point(10, 15);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(100, 23);
            this.lblLop.TabIndex = 0;
            this.lblLop.Text = "Lớp";
            // 
            // cboLop
            // 
            this.cboLop.Location = new System.Drawing.Point(120, 12);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(150, 33);
            this.cboLop.TabIndex = 1;
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.Location = new System.Drawing.Point(10, 45);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(100, 23);
            this.lblMonHoc.TabIndex = 2;
            this.lblMonHoc.Text = "Môn học";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.Location = new System.Drawing.Point(120, 42);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(150, 33);
            this.cboMonHoc.TabIndex = 3;
            // 
            // lblGiangVien
            // 
            this.lblGiangVien.Location = new System.Drawing.Point(10, 75);
            this.lblGiangVien.Name = "lblGiangVien";
            this.lblGiangVien.Size = new System.Drawing.Size(100, 23);
            this.lblGiangVien.TabIndex = 4;
            this.lblGiangVien.Text = "Giảng viên";
            // 
            // cboGiangVien
            // 
            this.cboGiangVien.Location = new System.Drawing.Point(120, 72);
            this.cboGiangVien.Name = "cboGiangVien";
            this.cboGiangVien.Size = new System.Drawing.Size(150, 33);
            this.cboGiangVien.TabIndex = 5;
            // 
            // lblHocKy
            // 
            this.lblHocKy.Location = new System.Drawing.Point(10, 105);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(100, 23);
            this.lblHocKy.TabIndex = 6;
            this.lblHocKy.Text = "Học kỳ";
            // 
            // cboHocKy
            // 
            this.cboHocKy.Location = new System.Drawing.Point(120, 105);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(150, 33);
            this.cboHocKy.TabIndex = 7;
            // 
            // lblThu
            // 
            this.lblThu.Location = new System.Drawing.Point(10, 135);
            this.lblThu.Name = "lblThu";
            this.lblThu.Size = new System.Drawing.Size(100, 23);
            this.lblThu.TabIndex = 8;
            this.lblThu.Text = "Thứ";
            // 
            // txtThu
            // 
            this.txtThu.Location = new System.Drawing.Point(120, 135);
            this.txtThu.Name = "txtThu";
            this.txtThu.Size = new System.Drawing.Size(150, 31);
            this.txtThu.TabIndex = 9;
            // 
            // lblTietBD
            // 
            this.lblTietBD.Location = new System.Drawing.Point(10, 165);
            this.lblTietBD.Name = "lblTietBD";
            this.lblTietBD.Size = new System.Drawing.Size(100, 23);
            this.lblTietBD.TabIndex = 10;
            this.lblTietBD.Text = "Tiết bắt đầu";
            // 
            // txtTietBD
            // 
            this.txtTietBD.Location = new System.Drawing.Point(120, 162);
            this.txtTietBD.Name = "txtTietBD";
            this.txtTietBD.Size = new System.Drawing.Size(150, 31);
            this.txtTietBD.TabIndex = 11;
            // 
            // lblSoTiet
            // 
            this.lblSoTiet.Location = new System.Drawing.Point(10, 195);
            this.lblSoTiet.Name = "lblSoTiet";
            this.lblSoTiet.Size = new System.Drawing.Size(100, 23);
            this.lblSoTiet.TabIndex = 12;
            this.lblSoTiet.Text = "Số tiết";
            // 
            // txtSoTiet
            // 
            this.txtSoTiet.Location = new System.Drawing.Point(120, 192);
            this.txtSoTiet.Name = "txtSoTiet";
            this.txtSoTiet.Size = new System.Drawing.Size(150, 31);
            this.txtSoTiet.TabIndex = 13;
            // 
            // dgvLichHoc
            // 
            this.dgvLichHoc.ColumnHeadersHeight = 46;
            this.dgvLichHoc.Location = new System.Drawing.Point(305, 15);
            this.dgvLichHoc.Name = "dgvLichHoc";
            this.dgvLichHoc.RowHeadersWidth = 82;
            this.dgvLichHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichHoc.Size = new System.Drawing.Size(668, 381);
            this.dgvLichHoc.TabIndex = 14;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(10, 230);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(100, 230);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(190, 230);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmLichHoc
            // 
            this.ClientSize = new System.Drawing.Size(996, 585);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.lblMonHoc);
            this.Controls.Add(this.cboMonHoc);
            this.Controls.Add(this.lblGiangVien);
            this.Controls.Add(this.cboGiangVien);
            this.Controls.Add(this.lblHocKy);
            this.Controls.Add(this.cboHocKy);
            this.Controls.Add(this.lblThu);
            this.Controls.Add(this.txtThu);
            this.Controls.Add(this.lblTietBD);
            this.Controls.Add(this.txtTietBD);
            this.Controls.Add(this.lblSoTiet);
            this.Controls.Add(this.txtSoTiet);
            this.Controls.Add(this.dgvLichHoc);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnRefresh);
            this.Name = "frmLichHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Lịch Học";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
