namespace QLSV.GUI
{
    partial class frmDangKyHoc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.DataGridView dgvDangKy;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.dgvDangKy = new System.Windows.Forms.DataGridView();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.Text = "Chọn Môn Học";
            this.lblMonHoc.Location = new System.Drawing.Point(10, 20);
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.Location = new System.Drawing.Point(120, 15);
            this.cboMonHoc.Size = new System.Drawing.Size(200, 24);
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // dgvDangKy
            // 
            this.dgvDangKy.Location = new System.Drawing.Point(350, 15);
            this.dgvDangKy.Size = new System.Drawing.Size(400, 200);
            this.dgvDangKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.Location = new System.Drawing.Point(10, 60);
            this.btnDangKy.Size = new System.Drawing.Size(80, 30);
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Location = new System.Drawing.Point(100, 60);
            this.btnHuy.Size = new System.Drawing.Size(80, 30);
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(190, 60);
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmDangKyHoc
            // 
            this.ClientSize = new System.Drawing.Size(770, 240);
            this.Controls.Add(this.lblMonHoc);
            this.Controls.Add(this.cboMonHoc);
            this.Controls.Add(this.dgvDangKy);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnRefresh);
            this.Text = "Đăng ký học";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
