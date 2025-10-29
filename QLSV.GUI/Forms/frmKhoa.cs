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
            dgvKhoa.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var khoa = new Khoa
            {
                TenKhoa = txtTenKhoa.Text.Trim()
            };

            if (string.IsNullOrEmpty(khoa.TenKhoa))
            {
                MessageBox.Show("Tên khoa không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (khoaService.Add(khoa))
            {
                MessageBox.Show("Thêm khoa thành công!");
                LoadData();
                txtTenKhoa.Clear();
            }
            else
                MessageBox.Show("Thêm thất bại!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhoa.CurrentRow == null) return;

            int maKhoa = (int)dgvKhoa.CurrentRow.Cells["MaKhoa"].Value;
            var khoa = khoaService.GetById(maKhoa);
            if (khoa == null) return;

            khoa.TenKhoa = txtTenKhoa.Text.Trim();
            if (string.IsNullOrEmpty(khoa.TenKhoa))
            {
                MessageBox.Show("Tên khoa không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (khoaService.Update(khoa))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
            else
                MessageBox.Show("Cập nhật thất bại!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhoa.CurrentRow == null) return;

            int maKhoa = (int)dgvKhoa.CurrentRow.Cells["MaKhoa"].Value;
            if (MessageBox.Show("Bạn có chắc muốn xóa khoa này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (khoaService.Delete(maKhoa))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }
                else
                    MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            txtTenKhoa.Clear();
        }

        private void dgvKhoa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhoa.CurrentRow != null)
                txtTenKhoa.Text = dgvKhoa.CurrentRow.Cells["TenKhoa"].Value.ToString();
        }
    }
}
