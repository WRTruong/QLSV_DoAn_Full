using System;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL;


namespace QLSV.GUI
{
    public partial class frmThongBao : Form
    {
        private readonly ThongBaoService tbService = new ThongBaoService();

        public frmThongBao()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvThongBao.DataSource = null;
            dgvThongBao.DataSource = tbService.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tb = new ThongBao
            {
                TieuDe = txtTieuDe.Text,
                NoiDung = txtNoiDung.Text,
                NgayTB = DateTime.Now
            };

            if (tbService.Add(tb))
            {
                MessageBox.Show("Thêm thông báo thành công!");
                LoadData();
                txtTieuDe.Clear();
                txtNoiDung.Clear();
            }
            else MessageBox.Show("Thất bại!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvThongBao.CurrentRow == null) return;

            int maTB = (int)dgvThongBao.CurrentRow.Cells["MaTB"].Value;

            if (tbService.Delete(maTB))
            {
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
            else MessageBox.Show("Xóa thất bại!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
