namespace QLSV.GUI
{
    partial class frmLop
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.DataGridView dgvLop;
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
            this.lblTenLop = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenLop
            // 
            this.lblTenLop.Text = "Tên Lớp";
            this.lblTenLop.Location = new System.Drawing.Point(10, 20);
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(100, 15);
            this.txtTenLop.Size = new System.Drawing.Size(200, 22);
            // 
            // lblKhoa
            // 
            this.lblKhoa.Text = "Khoa";
            this.lblKhoa.Location = new System.Drawing.Point(10, 55);
            // 
            // cbKhoa
            // 
            this.cbKhoa.Location = new System.Drawing.Point(100, 50);
            this.cbKhoa.Size = new System.Drawing.Size(200, 24);
            // 
            // dgvLop
            // 
            this.dgvLop.Location = new System.Drawing.Point(320, 15);
            this.dgvLop.Size = new System.Drawing.Size(400, 200);
            this.dgvLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLop.AutoGenerateColumns = false;
            this.dgvLop.SelectionChanged += new System.EventHandler(this.dgvLop_SelectionChanged);
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
            // frmLop
            // 
            this.ClientSize = new System.Drawing.Size(740, 230);
            this.Controls.Add(this.lblTenLop);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.dgvLop);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnRefresh);
            this.Text = "Quản lý Lớp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
