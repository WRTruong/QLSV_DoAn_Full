namespace QLSV.GUI
{
    partial class frmThongBao
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvThongBao;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboSinhVien;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblSinhVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvThongBao = new System.Windows.Forms.DataGridView();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.cboSinhVien = new System.Windows.Forms.ComboBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblSinhVien = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongBao
            // 
            this.dgvThongBao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongBao.ColumnHeadersHeight = 46;
            this.dgvThongBao.Location = new System.Drawing.Point(12, 12);
            this.dgvThongBao.MultiSelect = false;
            this.dgvThongBao.Name = "dgvThongBao";
            this.dgvThongBao.ReadOnly = true;
            this.dgvThongBao.RowHeadersWidth = 82;
            this.dgvThongBao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongBao.Size = new System.Drawing.Size(760, 250);
            this.dgvThongBao.TabIndex = 0;
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(120, 280);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(300, 31);
            this.txtTieuDe.TabIndex = 2;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(120, 310);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(300, 60);
            this.txtNoiDung.TabIndex = 4;
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.Location = new System.Drawing.Point(520, 280);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(200, 33);
            this.cboLop.TabIndex = 6;
            // 
            // cboSinhVien
            // 
            this.cboSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSinhVien.Location = new System.Drawing.Point(520, 310);
            this.cboSinhVien.Name = "cboSinhVien";
            this.cboSinhVien.Size = new System.Drawing.Size(200, 33);
            this.cboSinhVien.TabIndex = 8;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Location = new System.Drawing.Point(12, 280);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(100, 23);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "Tiêu đề:";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.Location = new System.Drawing.Point(12, 310);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(100, 23);
            this.lblNoiDung.TabIndex = 3;
            this.lblNoiDung.Text = "Nội dung:";
            // 
            // lblLop
            // 
            this.lblLop.Location = new System.Drawing.Point(450, 280);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(64, 23);
            this.lblLop.TabIndex = 5;
            this.lblLop.Text = "Lớp:";
            // 
            // lblSinhVien
            // 
            this.lblSinhVien.Location = new System.Drawing.Point(450, 310);
            this.lblSinhVien.Name = "lblSinhVien";
            this.lblSinhVien.Size = new System.Drawing.Size(64, 23);
            this.lblSinhVien.TabIndex = 7;
            this.lblSinhVien.Text = "Sinh viên:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(120, 380);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(240, 380);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(360, 380);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmThongBao
            // 
            this.ClientSize = new System.Drawing.Size(784, 431);
            this.Controls.Add(this.dgvThongBao);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.txtTieuDe);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.lblSinhVien);
            this.Controls.Add(this.cboSinhVien);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnRefresh);
            this.Name = "frmThongBao";
            this.Text = "Quản lý Thông báo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
