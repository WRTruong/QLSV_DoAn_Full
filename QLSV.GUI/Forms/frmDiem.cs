using System;
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

        public frmDiem()
        {
            InitializeComponent();
            LoadComboBox();
            LoadData();
        }

        private void LoadComboBox()
        {
            cboSinhVien.DataSource = svService.GetAll();
            cboSinhVien.DisplayMember = "HoTen";
            cboSinhVien.ValueMember = "MaSV";

            cboMonHoc.DataSource = mhService.GetAll();
            cboMonHoc.DisplayMember = "TenMH";
            cboMonHoc.ValueMember = "MaMH";
        }

        private void LoadData()
        {
            dgvDiem.DataSource = null;
            dgvDiem.DataSource = diemService.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var d = new Diem
            {
                MaSV = (int)cboSinhVien.SelectedValue,
                MaMH = (int)cboMonHoc.SelectedValue,
                DiemQT = (float)nudQT.Value,
                DiemCK = (float)nudCK.Value
            };

            if (diemService.AddOrUpdate(d))
            {
                MessageBox.Show("Thêm/Cập nhật điểm thành công!");
                LoadData();
            }
            else MessageBox.Show("Thất bại!");
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
            else MessageBox.Show("Thất bại!");
        }

        private void dgvDiem_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiem.CurrentRow == null) return;

            cboSinhVien.SelectedValue = (int)dgvDiem.CurrentRow.Cells["MaSV"].Value;
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
