using System;
using System.Linq;
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
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            LoadLop();
            LoadSinhVien();
        }

        private void LoadLop()
        {
            cboLop.DataSource = lopService.GetAll();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
        }

        private void LoadSinhVien()
        {
            dgvSinhVien.DataSource = null;
            dgvSinhVien.DataSource = svService.GetAll()
                .Select(sv => new
                {
                    sv.MaSV,
                    sv.HoTen,
                    GioiTinh = sv.GioiTinh == true ? "Nam" : "Nữ",
                    sv.NgaySinh,
                    sv.DiaChi,
                    sv.QueQuan,
                    sv.SDT,
                    sv.Email,
                    sv.MaLop, // thêm MaLop để sử dụng
                    Lop = sv.Lop != null ? sv.Lop.TenLop : "",
                    sv.HocPhi,
                    sv.TrangThai
                }).ToList();

            dgvSinhVien.Columns["MaLop"].Visible = false; // ẩn cột khóa ngoại
        }


        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvSinhVien.Rows[e.RowIndex];
            txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
            txtSDT.Text = row.Cells["SDT"].Value?.ToString();
            txtQueQuan.Text = row.Cells["QueQuan"].Value?.ToString();

            // Sử dụng MaLop thay vì tên lớp
            cboLop.SelectedValue = Convert.ToInt32(row.Cells["MaLop"].Value);

            chkTrangThai.Checked = Convert.ToBoolean(row.Cells["TrangThai"].Value);
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            var sv = new SinhVien
            {
                HoTen = txtHoTen.Text,
                DiaChi = txtDiaChi.Text,
                Email = txtEmail.Text,
                SDT = txtSDT.Text,
                QueQuan = txtQueQuan.Text,
                MaLop = Convert.ToInt32(cboLop.SelectedValue),
                TrangThai = chkTrangThai.Checked
            };

            if (svService.Add(sv))
            {
                MessageBox.Show("Thêm sinh viên thành công!");
                LoadSinhVien();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null) return;

            int maSV = Convert.ToInt32(dgvSinhVien.CurrentRow.Cells["MaSV"].Value);
            var sv = svService.GetById(maSV);
            if (sv == null) return;

            sv.HoTen = txtHoTen.Text;
            sv.DiaChi = txtDiaChi.Text;
            sv.Email = txtEmail.Text;
            sv.SDT = txtSDT.Text;
            sv.QueQuan = txtQueQuan.Text;
            sv.MaLop = Convert.ToInt32(cboLop.SelectedValue);
            sv.TrangThai = chkTrangThai.Checked;

            if (svService.Update(sv))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadSinhVien();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null) return;

            int maSV = Convert.ToInt32(dgvSinhVien.CurrentRow.Cells["MaSV"].Value);
            if (svService.Delete(maSV))
            {
                MessageBox.Show("Xóa thành công!");
                LoadSinhVien();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSinhVien();
        }
    }
}
