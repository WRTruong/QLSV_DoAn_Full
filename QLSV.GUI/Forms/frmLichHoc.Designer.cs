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
            this.lblLop.Text = "Lớp";
            this.lblLop.Location = new System.Drawing.Point(10, 15);
            // 
            // cboLop
            // 
            this.cboLop.Location = new System.Drawing.Point(80, 10);
            this.cboLop.Size = new System.Drawing.Size(150, 24);
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.Text = "Môn học";
            this.lblMonHoc.Location = new System.Drawing.Point(10, 45);
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.Location = new System.Drawing.Point(80, 40);
            this.cboMonHoc.Size = new System.Drawing.Size(150, 24);
            // 
            // lblGiangVien
            // 
            this.lblGiangVien.Text = "Giảng viên";
            this.lblGiangVien.Location = new System.Drawing.Point(10, 75);
            // 
            // cboGiangVien
            // 
            this.cboGiangVien.Location = new System.Drawing.Point(80, 70);
            this.cboGiangVien.Size = new System.Drawing.Size(150, 24);
            // 
            // lblHocKy
            // 
            this.lblHocKy.Text = "Học kỳ";
            this.lblHocKy.Location = new System.Drawing.Point(10, 105);
            // 
            // cboHocKy
            // 
            this.cboHocKy.Location = new System.Drawing.Point(80, 100);
            this.cboHocKy.Size = new System.Drawing.Size(150, 24);
            // 
            // lblThu
            // 
            this.lblThu.Text = "Thứ";
            this.lblThu.Location = new System.Drawing.Point(10, 135);
            // 
            // txtThu
            // 
            this.txtThu.Location = new System.Drawing.Point(80, 130);
            this.txtThu.Size = new System.Drawing.Size(150, 24);
            // 
            // lblTietBD
            // 
            this.lblTietBD.Text = "Tiết bắt đầu";
            this.lblTietBD.Location = new System.Drawing.Point(10, 165);
            // 
            // txtTietBD
            // 
            this.txtTietBD.Location = new System.Drawing.Point(80, 160);
            this.txtTietBD.Size = new System.Drawing.Size(150, 24);
            // 
            // lblSoTiet
            // 
            this.lblSoTiet.Text = "Số tiết";
            this.lblSoTiet.Location = new System.Drawing.Point(10, 195);
            // 
            // txtSoTiet
            // 
            this.txtSoTiet.Location = new System.Drawing.Point(80, 190);
            this.txtSoTiet.Size = new System.Drawing.Size(150, 24);
            // 
            // dgvLichHoc
            // 
            this.dgvLichHoc.Location = new System.Drawing.Point(250, 10);
            this.dgvLichHoc.Size = new System.Drawing.Size(500, 200);
            this.dgvLichHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnThem
            // 
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(10, 230);
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(100, 230);
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(190, 230);
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmLichHoc
            // 
            this.ClientSize = new System.Drawing.Size(770, 280);
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

            this.Text = "Quản lý Lịch Học";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
