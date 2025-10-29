using System;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL;

namespace QLSV.GUI
{
    public partial class frmLop : Form
    {
        private readonly LopService lopService = new LopService();
        private readonly KhoaService khoaService = new KhoaService();

        public frmLop()
        {
            InitializeComponent();
            LoadComboKhoa();
            LoadData();
        }

        private void LoadComboKhoa()
        {
            cbKhoa.DataSource = khoaService.GetAll();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }

        private void LoadData()
        {
            dgvLop.DataSource = null;
            dgvLop.DataSource = lopService.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var lop = new Lop
            {
                TenLop = txtTenLop.Text,
                MaKhoa = (int)cbKhoa.SelectedValue
            };

            if (lopService.Add(lop))
            {
                MessageBox.Show("Thêm thành công!");
                LoadData();
            }
            else MessageBox.Show("Thêm thất bại!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLop.CurrentRow == null) return;

            var maLop = (int)dgvLop.CurrentRow.Cells["MaLop"].Value;
            var lop = new Lop
            {
                MaLop = maLop,
                TenLop = txtTenLop.Text,
                MaKhoa = (int)cbKhoa.SelectedValue
            };

            if (lopService.Update(lop))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
            else MessageBox.Show("Cập nhật thất bại!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLop.CurrentRow == null) return;

            var maLop = (int)dgvLop.CurrentRow.Cells["MaLop"].Value;
            if (lopService.Delete(maLop))
            {
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
            else MessageBox.Show("Xóa thất bại!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            txtTenLop.Clear();
            cbKhoa.SelectedIndex = 0;
        }

        private void dgvLop_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLop.CurrentRow == null) return;

            txtTenLop.Text = dgvLop.CurrentRow.Cells["TenLop"].Value.ToString();
            cbKhoa.SelectedValue = (int)dgvLop.CurrentRow.Cells["MaKhoa"].Value;
        }
    }
}
