using System;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL;


namespace QLSV.GUI
{
    public partial class frmHocKy : Form
    {
        private readonly HocKyService hkService = new HocKyService();

        public frmHocKy()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvHocKy.DataSource = null;
            dgvHocKy.DataSource = hkService.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var hk = new HocKy
            {
                TenHK = txtTenHocKy.Text,
            };

            if (hkService.Add(hk))
            {
                MessageBox.Show("Thêm học kỳ thành công!");
                LoadData();
                txtTenHocKy.Clear();
                txtMoTa.Clear();
            }
            else MessageBox.Show("Thất bại!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHocKy.CurrentRow == null) return;

            int maHK = (int)dgvHocKy.CurrentRow.Cells["MaHK"].Value;
            var hk = new HocKy
            {
                MaHK = maHK,
                TenHK = txtTenHocKy.Text,
            };

            if (hkService.Update(hk))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
            else MessageBox.Show("Thất bại!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHocKy.CurrentRow == null) return;

            int maHK = (int)dgvHocKy.CurrentRow.Cells["MaHK"].Value;

            if (hkService.Delete(maHK))
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

        private void dgvHocKy_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHocKy.CurrentRow == null) return;

            txtTenHocKy.Text = dgvHocKy.CurrentRow.Cells["TenHK"].Value.ToString();
            txtMoTa.Text = dgvHocKy.CurrentRow.Cells["MoTa"].Value?.ToString();
        }
    }
}
