namespace QLSV.GUI
{
    partial class frmDangKyHoc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSinhVien;
        private System.Windows.Forms.ComboBox cboSinhVien;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.ComboBox cboHocKy;
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
            this.lblSinhVien = new System.Windows.Forms.Label();
            this.cboSinhVien = new System.Windows.Forms.ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.dgvDangKy = new System.Windows.Forms.DataGridView();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKy)).BeginInit();
            this.SuspendLayout();

            // lblSinhVien
            this.lblSinhVien.AutoSize = true;
            this.lblSinhVien.Location = new System.Drawing.Point(20, 20);
            this.lblSinhVien.Name = "lblSinhVien";
            this.lblSinhVien.Size = new System.Drawing.Size(70, 17);
            this.lblSinhVien.Text = "Sinh viên";

            // cboSinhVien
            this.cboSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSinhVien.Location = new System.Drawing.Point(100, 17);
            this.cboSinhVien.Size = new System.Drawing.Size(180, 24);
            this.cboSinhVien.Name = "cboSinhVien";

            // lblHocKy
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(300, 20);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(50, 17);
            this.lblHocKy.Text = "Học kỳ";

            // cboHocKy
            this.cboHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocKy.Location = new System.Drawing.Point(360, 17);
            this.cboHocKy.Size = new System.Drawing.Size(150, 24);
            this.cboHocKy.Name = "cboHocKy";

            // lblMonHoc
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Location = new System.Drawing.Point(540, 20);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(80, 17);
            this.lblMonHoc.Text = "Chọn môn";

            // cboMonHoc
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.Location = new System.Drawing.Point(620, 17);
            this.cboMonHoc.Size = new System.Drawing.Size(200, 24);
            this.cboMonHoc.Name = "cboMonHoc";

            // dgvDangKy
            this.dgvDangKy.Location = new System.Drawing.Point(20, 60);
            this.dgvDangKy.Size = new System.Drawing.Size(800, 300);
            this.dgvDangKy.Name = "dgvDangKy";
            this.dgvDangKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDangKy.ReadOnly = true;
            this.dgvDangKy.AllowUserToAddRows = false;
            this.dgvDangKy.AllowUserToDeleteRows = false;
            this.dgvDangKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // btnDangKy
            this.btnDangKy.Location = new System.Drawing.Point(20, 380);
            this.btnDangKy.Size = new System.Drawing.Size(100, 35);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);

            // btnHuy
            this.btnHuy.Location = new System.Drawing.Point(140, 380);
            this.btnHuy.Size = new System.Drawing.Size(100, 35);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(260, 380);
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // frmDangKyHoc
            this.ClientSize = new System.Drawing.Size(850, 430);
            this.Controls.Add(this.lblSinhVien);
            this.Controls.Add(this.cboSinhVien);
            this.Controls.Add(this.lblHocKy);
            this.Controls.Add(this.cboHocKy);
            this.Controls.Add(this.lblMonHoc);
            this.Controls.Add(this.cboMonHoc);
            this.Controls.Add(this.dgvDangKy);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnRefresh);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký học phần";
            this.Name = "frmDangKyHoc";

            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
