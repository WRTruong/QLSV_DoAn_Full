using System;
using System.Linq;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL;

namespace QLSV.GUI
{
    public partial class frmThongBaoSV : Form
    {
        private readonly ThongBaoService tbService = new ThongBaoService();
        private readonly int maSV;

        public frmThongBaoSV(int maSV)
        {
            InitializeComponent();
            this.maSV = maSV;

            dgvThongBao.SelectionChanged += DgvThongBao_SelectionChanged;
            btnRefresh.Click += BtnRefresh_Click;

            LoadData();
        }

        private void LoadData()
        {
            dgvThongBao.DataSource = null;

            var allTB = tbService.GetAll();

            // Lọc thông báo: toàn bộ, theo lớp, theo sinh viên
            var data = allTB.Where(tb =>
                (tb.MaSV == null && tb.MaLop == null) // thông báo toàn bộ
                || tb.MaSV == maSV                   // thông báo riêng SV
                || (tb.MaLop != null && tb.SinhVien != null && tb.SinhVien.MaSV == maSV) // thông báo theo lớp
            )
            .Select(tb => new
            {
                tb.MaTB,
                tb.TieuDe,
                tb.NoiDung,
                NgayTB = tb.NgayTB?.ToString("dd/MM/yyyy HH:mm"),
                TenLop = tb.Lop != null ? tb.Lop.TenLop : "",
            })
            .OrderByDescending(tb => tb.NgayTB)
            .ToList();

            dgvThongBao.DataSource = data;

            dgvThongBao.Columns["MaTB"].Visible = false;
            dgvThongBao.Columns["NoiDung"].Visible = false; // ẩn cột nội dung, chỉ show khi click
        }

        private void DgvThongBao_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThongBao.CurrentRow == null) return;

            txtTieuDe.Text = dgvThongBao.CurrentRow.Cells["TieuDe"].Value?.ToString();
            txtNoiDung.Text = dgvThongBao.CurrentRow.Cells["NoiDung"].Value?.ToString();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            txtTieuDe.Clear();
            txtNoiDung.Clear();
        }
    }
}
