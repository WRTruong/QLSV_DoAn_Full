using System;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL;

namespace QLSV.GUI
{
    public partial class frmKhoa : Form
    {
        private readonly KhoaService khoaService = new KhoaService();

        public frmKhoa()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvKhoa.DataSource = null;
            dgvKhoa.DataSource = khoaService.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var khoa = new Khoa
            {
                TenKhoa = txtTenKhoa.Text,
            };

            if (khoaService.Add(khoa))
            {
                MessageBox.Show("Thêm thành công!");
                LoadData();
            }
            else MessageBox.Show("Thêm thất bại!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhoa.CurrentRow == null) return;

            var maKhoa = (int)dgvKhoa.CurrentRow.Cells["MaKhoa"].Value;
            var khoa = new Khoa
            {
                MaKhoa = maKhoa,
                TenKhoa = txtTenKhoa.Text,
            };

            if (khoaService.Update(khoa))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
            else MessageBox.Show("Cập nhật thất bại!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhoa.CurrentRow == null) return;

            var maKhoa = (int)dgvKhoa.CurrentRow.Cells["MaKhoa"].Value;
            if (khoaService.Delete(maKhoa))
            {
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
            else MessageBox.Show("Xóa thất bại!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            txtTenKhoa.Clear();
            txtMoTa.Clear();
        }

        private void dgvKhoa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhoa.CurrentRow == null) return;

            txtTenKhoa.Text = dgvKhoa.CurrentRow.Cells["TenKhoa"].Value.ToString();
            txtMoTa.Text = dgvKhoa.CurrentRow.Cells["MoTa"].Value.ToString();
        }
    }
}
