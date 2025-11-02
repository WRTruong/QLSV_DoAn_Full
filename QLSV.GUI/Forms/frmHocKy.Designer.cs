namespace QLSV.GUI
{
    partial class frmHocKy
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTenHK;
        private System.Windows.Forms.TextBox txtTenHocKy;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.DataGridView dgvHocKy;
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
            this.lblTenHK = new System.Windows.Forms.Label();
            this.txtTenHocKy = new System.Windows.Forms.TextBox();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.dgvHocKy = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocKy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenHK
            // 
            this.lblTenHK.Location = new System.Drawing.Point(10, 20);
            this.lblTenHK.Name = "lblTenHK";
            this.lblTenHK.Size = new System.Drawing.Size(100, 23);
            this.lblTenHK.TabIndex = 0;
            this.lblTenHK.Text = "Tên Học Kỳ";
            // 
            // txtTenHocKy
            // 
            this.txtTenHocKy.Location = new System.Drawing.Point(120, 15);
            this.txtTenHocKy.Name = "txtTenHocKy";
            this.txtTenHocKy.Size = new System.Drawing.Size(200, 31);
            this.txtTenHocKy.TabIndex = 1;
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.Location = new System.Drawing.Point(10, 55);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(100, 23);
            this.lblNamHoc.TabIndex = 2;
            this.lblNamHoc.Text = "Năm Học";
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(120, 50);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(200, 31);
            this.txtNamHoc.TabIndex = 3;
            // 
            // dgvHocKy
            // 
            this.dgvHocKy.ColumnHeadersHeight = 46;
            this.dgvHocKy.Location = new System.Drawing.Point(350, 15);
            this.dgvHocKy.Name = "dgvHocKy";
            this.dgvHocKy.RowHeadersWidth = 82;
            this.dgvHocKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocKy.Size = new System.Drawing.Size(400, 200);
            this.dgvHocKy.TabIndex = 4;
            this.dgvHocKy.SelectionChanged += new System.EventHandler(this.dgvHocKy_SelectionChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(10, 100);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(100, 100);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(190, 100);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(10, 145);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmHocKy
            // 
            this.ClientSize = new System.Drawing.Size(770, 240);
            this.Controls.Add(this.lblTenHK);
            this.Controls.Add(this.txtTenHocKy);
            this.Controls.Add(this.lblNamHoc);
            this.Controls.Add(this.txtNamHoc);
            this.Controls.Add(this.dgvHocKy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnRefresh);
            this.Name = "frmHocKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Học Kỳ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
