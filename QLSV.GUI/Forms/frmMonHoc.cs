using System;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL;


namespace QLSV.GUI
{
    public partial class frmMonHoc : Form
    {
        private readonly MonHocService mhService = new MonHocService();

        public frmMonHoc()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvMonHoc.DataSource = null;
            dgvMonHoc.DataSource = mhService.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var mh = new MonHoc
            {
                TenMH = txtTenMH.Text,
                SoTC = (int)nudSoTC.Value
            };

            if (mhService.Add(mh))
            {
                MessageBox.Show("Thêm thành công!");
                LoadData();
            }
            else MessageBox.Show("Thêm thất bại!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.CurrentRow == null) return;

            var maMH = (int)dgvMonHoc.CurrentRow.Cells["MaMH"].Value;
            var mh = new MonHoc
            {
                MaMH = maMH,
                TenMH = txtTenMH.Text,
                SoTC = (int)nudSoTC.Value
            };

            if (mhService.Update(mh))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
            else MessageBox.Show("Cập nhật thất bại!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.CurrentRow == null) return;

            var maMH = (int)dgvMonHoc.CurrentRow.Cells["MaMH"].Value;
            if (mhService.Delete(maMH))
            {
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
            else MessageBox.Show("Xóa thất bại!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            txtTenMH.Clear();
            nudSoTC.Value = 1;
        }

        private void dgvMonHoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMonHoc.CurrentRow == null) return;

            txtTenMH.Text = dgvMonHoc.CurrentRow.Cells["TenMH"].Value.ToString();
            nudSoTC.Value = Convert.ToDecimal(dgvMonHoc.CurrentRow.Cells["SoTC"].Value);
           
        }
    }
}
