using System;
using System.Linq;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL;

namespace QLSV.GUI
{
    public partial class frmDiem : Form
    {
        private readonly DiemService diemService = new DiemService();
        private readonly SinhVienService svService = new SinhVienService();
        private readonly MonHocService mhService = new MonHocService();

        private readonly string userRole;
        private readonly int? maSV;
        private readonly int? maGV;

        public frmDiem(string role, int? maSV = null, int? maGV = null)
        {
            InitializeComponent();
            userRole = role;
            this.maSV = maSV;
            this.maGV = maGV;

            SetupFormByRole();
            LoadComboBox();
            LoadData();
        }

        private void SetupFormByRole()
        {
            if (userRole == "Admin")
            {
                cboSinhVien.Visible = true;
                lblSinhVien.Visible = true;
                cboMonHoc.Visible = true;
                lblMonHoc.Visible = true;
                dgvDiem.ReadOnly = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
            }
            else if (userRole == "GiangVien")
            {
                cboSinhVien.Visible = false;
                lblSinhVien.Visible = false;

                cboMonHoc.Visible = true;
                lblMonHoc.Visible = true;

                dgvDiem.ReadOnly = false; // cho phép sửa điểm
                btnThem.Enabled = true;
                btnXoa.Enabled = false; // giảng viên không xóa điểm
            }
            else if (userRole == "SinhVien")
            {
                cboSinhVien.Visible = false;
                lblSinhVien.Visible = false;
                cboMonHoc.Visible = false;
                lblMonHoc.Visible = false;

                dgvDiem.ReadOnly = true; // chỉ xem
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void LoadComboBox()
        {
            if (userRole == "Admin")
            {
                cboSinhVien.DataSource = svService.GetAll();
                cboSinhVien.DisplayMember = "HoTen";
                cboSinhVien.ValueMember = "MaSV";

                cboMonHoc.DataSource = mhService.GetAll();
                cboMonHoc.DisplayMember = "TenMH";
                cboMonHoc.ValueMember = "MaMH";
            }
            else if (userRole == "GiangVien")
            {
                // chỉ lấy môn giảng viên dạy
                cboMonHoc.DataSource = mhService.GetMonHocByGiangVien(maGV.Value);
                cboMonHoc.DisplayMember = "TenMH";
                cboMonHoc.ValueMember = "MaMH";
            }
        }

        private void LoadData()
        {
            object data = null;

            if (userRole == "Admin")
            {
                data = diemService.GetAll()
                    .Select(d => new
                    {
                        d.MaSV,
                        TenSV = d.SinhVien.HoTen,
                        d.MaMH,
                        TenMH = d.MonHoc.TenMH,
                        d.DiemQT,
                        d.DiemCK,
                        d.DiemTong
                    }).ToList();
            }
            else if (userRole == "GiangVien")
            {
                data = diemService.GetByGiangVien(maGV.Value)
                    .Select(d => new
                    {
                        d.MaSV,
                        TenSV = d.SinhVien.HoTen,
                        d.MaMH,
                        TenMH = d.MonHoc.TenMH,
                        d.DiemQT,
                        d.DiemCK,
                        d.DiemTong
                    }).ToList();
            }
            else if (userRole == "SinhVien")
            {
                data = diemService.GetBySinhVien(maSV.Value)
                    .Select(d => new
                    {
                        d.MaSV,
                        TenSV = d.SinhVien.HoTen,
                        d.MaMH,
                        TenMH = d.MonHoc.TenMH,
                        d.DiemQT,
                        d.DiemCK,
                        d.DiemTong
                    }).ToList();
            }

            dgvDiem.DataSource = data;

            // Tùy chỉnh header
            dgvDiem.Columns["MaSV"].HeaderText = "Mã SV";
            dgvDiem.Columns["TenSV"].HeaderText = "Họ tên SV";
            dgvDiem.Columns["MaMH"].HeaderText = "Mã môn";
            dgvDiem.Columns["TenMH"].HeaderText = "Tên môn học";
            dgvDiem.Columns["DiemQT"].HeaderText = "Điểm quá trình";
            dgvDiem.Columns["DiemCK"].HeaderText = "Điểm cuối kỳ";
            dgvDiem.Columns["DiemTong"].HeaderText = "Điểm tổng";
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            int selectedSV = userRole == "Admin" ? (int)cboSinhVien.SelectedValue : maSV.Value;
            int selectedMH = (int)cboMonHoc.SelectedValue;

            var d = new Diem
            {
                MaSV = selectedSV,
                MaMH = selectedMH,
                DiemQT = (float)nudQT.Value,
                DiemCK = (float)nudCK.Value
            };

            if (diemService.AddOrUpdate(d))
            {
                MessageBox.Show("Cập nhật điểm thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDiem.CurrentRow == null) return;

            int maSV = (int)dgvDiem.CurrentRow.Cells["MaSV"].Value;
            int maMH = (int)dgvDiem.CurrentRow.Cells["MaMH"].Value;

            if (diemService.Delete(maSV, maMH))
            {
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
            else
                MessageBox.Show("Thất bại!");
        }

        private void dgvDiem_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiem.CurrentRow == null) return;

            if (userRole == "Admin")
                cboSinhVien.SelectedValue = (int)dgvDiem.CurrentRow.Cells["MaSV"].Value;

            if (userRole != "SinhVien")
                cboMonHoc.SelectedValue = (int)dgvDiem.CurrentRow.Cells["MaMH"].Value;

            nudQT.Value = Convert.ToDecimal(dgvDiem.CurrentRow.Cells["DiemQT"].Value);
            nudCK.Value = Convert.ToDecimal(dgvDiem.CurrentRow.Cells["DiemCK"].Value);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            nudQT.Value = 0;
            nudCK.Value = 0;
        }
    }
}
