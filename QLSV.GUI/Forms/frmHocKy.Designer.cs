namespace QLSV.GUI
{
    partial class frmHocKy
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTenHK;
        private System.Windows.Forms.TextBox txtTenHocKy;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMoTa;
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
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
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
            this.lblTenHK.Text = "Tên Học Kỳ";
            this.lblTenHK.Location = new System.Drawing.Point(10, 20);
            // 
            // txtTenHocKy
            // 
            this.txtTenHocKy.Location = new System.Drawing.Point(120, 15);
            this.txtTenHocKy.Size = new System.Drawing.Size(200, 24);
            // 
            // lblMoTa
            // 
            this.lblMoTa.Text = "Mô tả";
            this.lblMoTa.Location = new System.Drawing.Point(10, 55);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(120, 50);
            this.txtMoTa.Size = new System.Drawing.Size(200, 80);
            this.txtMoTa.Multiline = true;
            // 
            // dgvHocKy
            // 
            this.dgvHocKy.Location = new System.Drawing.Point(350, 15);
            this.dgvHocKy.Size = new System.Drawing.Size(400, 200);
            this.dgvHocKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocKy.SelectionChanged += new System.EventHandler(this.dgvHocKy_SelectionChanged);
            // 
            // btnThem
            // 
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(10, 150);
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(100, 150);
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(190, 150);
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(280, 150);
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmHocKy
            // 
            this.ClientSize = new System.Drawing.Size(770, 240);
            this.Controls.Add(this.lblTenHK);
            this.Controls.Add(this.txtTenHocKy);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.dgvHocKy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnRefresh);
            this.Text = "Quản lý Học Kỳ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dgvHocKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
