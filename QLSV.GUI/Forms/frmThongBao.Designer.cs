namespace QLSV.GUI
{
    partial class frmThongBao
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.DataGridView dgvThongBao;
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.dgvThongBao = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Text = "Tiêu đề";
            this.lblTieuDe.Location = new System.Drawing.Point(10, 20);
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(120, 15);
            this.txtTieuDe.Size = new System.Drawing.Size(200, 24);
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.Text = "Nội dung";
            this.lblNoiDung.Location = new System.Drawing.Point(10, 55);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(120, 50);
            this.txtNoiDung.Size = new System.Drawing.Size(200, 80);
            this.txtNoiDung.Multiline = true;
            // 
            // dgvThongBao
            // 
            this.dgvThongBao.Location = new System.Drawing.Point(350, 15);
            this.dgvThongBao.Size = new System.Drawing.Size(400, 200);
            this.dgvThongBao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnThem
            // 
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(10, 150);
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(100, 150);
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(190, 150);
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmThongBao
            // 
            this.ClientSize = new System.Drawing.Size(770, 240);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.txtTieuDe);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.dgvThongBao);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnRefresh);
            this.Text = "Quản lý Thông Báo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
