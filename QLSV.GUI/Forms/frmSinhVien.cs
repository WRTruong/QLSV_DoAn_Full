using System;
using System.Drawing;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL;


namespace QLSV.GUI
{
    public partial class frmSinhVien : Form
    {
        private readonly SinhVienService svService = new SinhVienService();
        private readonly LopService lopService = new LopService();

        public frmSinhVien()
        {
            InitializeComponent();
            LoadData();
            LoadComboBox();
        }

        private void LoadData()
        {
            dgvSinhVien.DataSource = null;
            dgvSinhVien.DataSource = svService.GetAll();
        }

        private void LoadComboBox()
        {
            cboLop.DataSource = lopService.GetAll();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var sv = new SinhVien
            {
                HoTen = txtHoTen.Text,
                NgaySinh = dtpNgaySinh.Value,
                MaLop = (int)cboLop.SelectedValue,
                Email = txtEmail.Text,
                SDT = txtSDT.Text,
                DiaChi = txtDiaChi.Text,
                HinhAnh = picHinhAnh.ImageLocation
            };

            if (svService.Add(sv))
            {
                MessageBox.Show("Thêm thành công!");
                LoadData();
            }
            else MessageBox.Show("Thêm thất bại!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null) return;

            var maSV = (int)dgvSinhVien.CurrentRow.Cells["MaSV"].Value;
            var sv = svService.GetById(maSV);
            sv.HoTen = txtHoTen.Text;
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.MaLop = (int)cboLop.SelectedValue;
            sv.Email = txtEmail.Text;
            sv.SDT = txtSDT.Text;
            sv.DiaChi = txtDiaChi.Text;
            sv.HinhAnh = picHinhAnh.ImageLocation;

            if (svService.Update(sv))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
            else MessageBox.Show("Cập nhật thất bại!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null) return;

            var maSV = (int)dgvSinhVien.CurrentRow.Cells["MaSV"].Value;
            if (svService.Delete(maSV))
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
            dtpNgaySinh.Value = DateTime.Now;
            picHinhAnh.Image = null;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.ImageLocation = ofd.FileName;
            }
        }
    }
}
