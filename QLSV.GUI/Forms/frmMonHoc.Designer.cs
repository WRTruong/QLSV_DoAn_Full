namespace QLSV.GUI
{
    partial class frmMonHoc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTenMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label lblGiangVien;
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
            this.lblSoTC = new System.Windows.Forms.Label();
            this.nudSoTC = new System.Windows.Forms.NumericUpDown();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenMH
            // 
            this.lblTenMH.Location = new System.Drawing.Point(10, 20);
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.Size = new System.Drawing.Size(100, 23);
            this.lblTenMH.TabIndex = 0;
            this.lblTenMH.Text = "Tên Môn Học";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(120, 15);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(200, 31);
            this.txtTenMH.TabIndex = 1;
            // 
            // lblGiangVien
            // 
            this.lblGiangVien.Location = new System.Drawing.Point(10, 55);
            this.lblGiangVien.Name = "lblGiangVien";
            this.lblGiangVien.Size = new System.Drawing.Size(100, 23);
            this.lblGiangVien.TabIndex = 2;
            // 
            // lblSoTC
            // 
            this.lblSoTC.Location = new System.Drawing.Point(10, 90);
            this.lblSoTC.Name = "lblSoTC";
            this.lblSoTC.Size = new System.Drawing.Size(100, 23);
            this.lblSoTC.TabIndex = 4;
            this.lblSoTC.Text = "Số Tín Chỉ";
            // 
            // nudSoTC
            // 
            this.nudSoTC.Location = new System.Drawing.Point(120, 85);
            this.nudSoTC.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSoTC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoTC.Name = "nudSoTC";
            this.nudSoTC.Size = new System.Drawing.Size(120, 31);
            this.nudSoTC.TabIndex = 5;
            this.nudSoTC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.ColumnHeadersHeight = 46;
            this.dgvMonHoc.Location = new System.Drawing.Point(350, 15);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.RowHeadersWidth = 82;
            this.dgvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonHoc.Size = new System.Drawing.Size(400, 200);
            this.dgvMonHoc.TabIndex = 6;
            this.dgvMonHoc.SelectionChanged += new System.EventHandler(this.dgvMonHoc_SelectionChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(10, 130);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(100, 130);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(190, 130);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(280, 130);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmMonHoc
            // 
            this.ClientSize = new System.Drawing.Size(770, 260);
            this.Controls.Add(this.lblTenMH);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.lblGiangVien);
            this.Controls.Add(this.lblSoTC);
            this.Controls.Add(this.nudSoTC);
            this.Controls.Add(this.dgvMonHoc);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnRefresh);
            this.Name = "frmMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Môn Học";
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
