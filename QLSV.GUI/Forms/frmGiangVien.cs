using System;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL;


namespace QLSV.GUI
{
    public partial class frmGiangVien : Form
    {
        private readonly GiangVienService gvService = new GiangVienService();

        public frmGiangVien()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvGiangVien.DataSource = null;
            dgvGiangVien.DataSource = gvService.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var gv = new GiangVien
            {
                HoTen = txtHoTen.Text,
                GioiTinh = rbNam.Checked,
                NgaySinh = dtpNgaySinh.Value,
                Email = txtEmail.Text,
                DiaChi = txtDiaChi.Text
            };

            if (gvService.Add(gv))
            {
                MessageBox.Show("Thêm thành công!");
                LoadData();
            }
            else MessageBox.Show("Thêm thất bại!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvGiangVien.CurrentRow == null) return;

            var maGV = (int)dgvGiangVien.CurrentRow.Cells["MaGV"].Value;
            var gv = new GiangVien
            {
                MaGV = maGV,
                HoTen = txtHoTen.Text,
                GioiTinh = rbNam.Checked,
                NgaySinh = dtpNgaySinh.Value,
                Email = txtEmail.Text,
                DiaChi = txtDiaChi.Text
            };

            if (gvService.Update(gv))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
            else MessageBox.Show("Cập nhật thất bại!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGiangVien.CurrentRow == null) return;

            var maGV = (int)dgvGiangVien.CurrentRow.Cells["MaGV"].Value;
            if (gvService.Delete(maGV))
            {
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
            else MessageBox.Show("Xóa thất bại!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            rbNam.Checked = true;
        }

        private void dgvGiangVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGiangVien.CurrentRow == null) return;

            txtHoTen.Text = dgvGiangVien.CurrentRow.Cells["HoTen"].Value.ToString();
            txtEmail.Text = dgvGiangVien.CurrentRow.Cells["Email"].Value.ToString();
            txtSDT.Text = dgvGiangVien.CurrentRow.Cells["SDT"].Value.ToString();
            txtDiaChi.Text = dgvGiangVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            rbNam.Checked = (bool)dgvGiangVien.CurrentRow.Cells["GioiTinh"].Value;
            rbNu.Checked = !rbNam.Checked;
        }
    }
}
