namespace QLSV.GUI
{
    partial class frmDiem
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSinhVien;
        private System.Windows.Forms.ComboBox cboSinhVien;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Label lblQT;
        private System.Windows.Forms.NumericUpDown nudQT;
        private System.Windows.Forms.Label lblCK;
        private System.Windows.Forms.NumericUpDown nudCK;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSinhVien = new System.Windows.Forms.Label();
            this.cboSinhVien = new System.Windows.Forms.ComboBox();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.lblQT = new System.Windows.Forms.Label();
            this.nudQT = new System.Windows.Forms.NumericUpDown();
            this.lblCK = new System.Windows.Forms.Label();
            this.nudCK = new System.Windows.Forms.NumericUpDown();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCK)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSinhVien
            // 
            this.lblSinhVien.Text = "Sinh Viên";
            this.lblSinhVien.Location = new System.Drawing.Point(10, 20);
            // 
            // cboSinhVien
            // 
            this.cboSinhVien.Location = new System.Drawing.Point(120, 15);
            this.cboSinhVien.Size = new System.Drawing.Size(200, 24);
            this.cboSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.Text = "Môn Học";
            this.lblMonHoc.Location = new System.Drawing.Point(10, 55);
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.Location = new System.Drawing.Point(120, 50);
            this.cboMonHoc.Size = new System.Drawing.Size(200, 24);
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // lblQT
            // 
            this.lblQT.Text = "Điểm Quá Trình";
            this.lblQT.Location = new System.Drawing.Point(10, 90);
            // 
            // nudQT
            // 
            this.nudQT.Location = new System.Drawing.Point(120, 85);
            this.nudQT.DecimalPlaces = 2;
            this.nudQT.Maximum = 10;
            this.nudQT.Minimum = 0;
            this.nudQT.Value = 0;
            // 
            // lblCK
            // 
            this.lblCK.Text = "Điểm Cuối Kỳ";
            this.lblCK.Location = new System.Drawing.Point(10, 125);
            // 
            // nudCK
            // 
            this.nudCK.Location = new System.Drawing.Point(120, 120);
            this.nudCK.DecimalPlaces = 2;
            this.nudCK.Maximum = 10;
            this.nudCK.Minimum = 0;
            this.nudCK.Value = 0;
            // 
            // dgvDiem
            // 
            this.dgvDiem.Location = new System.Drawing.Point(350, 15);
            this.dgvDiem.Size = new System.Drawing.Size(400, 200);
            this.dgvDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiem.SelectionChanged += new System.EventHandler(this.dgvDiem_SelectionChanged);
            // 
            // btnThem
            // 
            this.btnThem.Text = "Thêm/Cập nhật";
            this.btnThem.Location = new System.Drawing.Point(10, 160);
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(120, 160);
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(210, 160);
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmDiem
            // 
            this.ClientSize = new System.Drawing.Size(770, 240);
            this.Controls.Add(this.lblSinhVien);
            this.Controls.Add(this.cboSinhVien);
            this.Controls.Add(this.lblMonHoc);
            this.Controls.Add(this.cboMonHoc);
            this.Controls.Add(this.lblQT);
            this.Controls.Add(this.nudQT);
            this.Controls.Add(this.lblCK);
            this.Controls.Add(this.nudCK);
            this.Controls.Add(this.dgvDiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnRefresh);
            this.Text = "Quản lý Điểm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
