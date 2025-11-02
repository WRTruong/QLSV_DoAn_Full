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
            if (string.IsNullOrWhiteSpace(txtTenHocKy.Text) || string.IsNullOrWhiteSpace(txtNamHoc.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên học kỳ và Năm học!");
                return;
            }

            var hk = new HocKy
            {
                TenHK = txtTenHocKy.Text,
                NamHoc = txtNamHoc.Text
            };

            if (hkService.Add(hk))
            {
                MessageBox.Show("Thêm học kỳ thành công!");
                LoadData();
                txtTenHocKy.Clear();
                txtNamHoc.Clear();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHocKy.CurrentRow == null) return;

            int maHK = Convert.ToInt32(dgvHocKy.CurrentRow.Cells["MaHK"].Value);

            var hk = new HocKy
            {
                MaHK = maHK,
                TenHK = txtTenHocKy.Text,
                NamHoc = txtNamHoc.Text
            };

            if (hkService.Update(hk))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHocKy.CurrentRow == null) return;

            int maHK = Convert.ToInt32(dgvHocKy.CurrentRow.Cells["MaHK"].Value);

            if (hkService.Delete(maHK))
            {
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtTenHocKy.Clear();
            txtNamHoc.Clear();
            LoadData();
        }

        private void dgvHocKy_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHocKy.CurrentRow == null) return;

            txtTenHocKy.Text = dgvHocKy.CurrentRow.Cells["TenHK"].Value?.ToString() ?? "";
            txtNamHoc.Text = dgvHocKy.CurrentRow.Cells["NamHoc"].Value?.ToString() ?? "";
        }
    }
}
