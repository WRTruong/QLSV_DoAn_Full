namespace QLSV.GUI
{
    partial class frmMonHoc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTenMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label lblGiangVien;
        private System.Windows.Forms.ComboBox cboGiangVien;
        private System.Windows.Forms.Label lblSoTC;
        private System.Windows.Forms.NumericUpDown nudSoTC;
        private System.Windows.Forms.DataGridView dgvMonHoc;
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
            this.lblTenMH = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.lblGiangVien = new System.Windows.Forms.Label();
            this.cboGiangVien = new System.Windows.Forms.ComboBox();
            this.lblSoTC = new System.Windows.Forms.Label();
            this.nudSoTC = new System.Windows.Forms.NumericUpDown();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenMH
            // 
            this.lblTenMH.Text = "Tên Môn Học";
            this.lblTenMH.Location = new System.Drawing.Point(10, 20);
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(120, 15);
            this.txtTenMH.Size = new System.Drawing.Size(200, 22);
            // 
            // lblGiangVien
            // 
            this.lblGiangVien.Text = "Giảng Viên";
            this.lblGiangVien.Location = new System.Drawing.Point(10, 55);
            // 
            // cboGiangVien
            // 
            this.cboGiangVien.Location = new System.Drawing.Point(120, 50);
            this.cboGiangVien.Size = new System.Drawing.Size(200, 24);
            this.cboGiangVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // lblSoTC
            // 
            this.lblSoTC.Text = "Số Tín Chỉ";
            this.lblSoTC.Location = new System.Drawing.Point(10, 90);
            // 
            // nudSoTC
            // 
            this.nudSoTC.Location = new System.Drawing.Point(120, 85);
            this.nudSoTC.Minimum = 1;
            this.nudSoTC.Maximum = 10;
            this.nudSoTC.Value = 1;
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.Location = new System.Drawing.Point(350, 15);
            this.dgvMonHoc.Size = new System.Drawing.Size(400, 200);
            this.dgvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonHoc.SelectionChanged += new System.EventHandler(this.dgvMonHoc_SelectionChanged);
            // 
            // btnThem
            // 
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(10, 130);
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(100, 130);
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(190, 130);
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(280, 130);
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmMonHoc
            // 
            this.ClientSize = new System.Drawing.Size(770, 260);
            this.Controls.Add(this.lblTenMH);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.lblGiangVien);
            this.Controls.Add(this.cboGiangVien);
            this.Controls.Add(this.lblSoTC);
            this.Controls.Add(this.nudSoTC);
            this.Controls.Add(this.dgvMonHoc);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnRefresh);
            this.Text = "Quản lý Môn Học";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
