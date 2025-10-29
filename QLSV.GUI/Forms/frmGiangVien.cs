using System;
using System.Linq;
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
            dgvGV.DataSource = gvService.GetAll()
                .Select(gv => new
                {
                    gv.MaGV,
                    gv.HoTen,
                    gv.Email,
                }).ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var gv = new GiangVien
            {
                HoTen = txtHoTen.Text,
                Email = txtEmail.Text,
            };
            if (gvService.Add(gv))
            {
                MessageBox.Show("Thêm thành công!");
                LoadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvGV.CurrentRow == null) return;
            int maGV = (int)dgvGV.CurrentRow.Cells["MaGV"].Value;
            var gv = gvService.GetById(maGV);
            gv.HoTen = txtHoTen.Text;
            gv.Email = txtEmail.Text;
            if (gvService.Update(gv))
            {
                MessageBox.Show("Sửa thành công!");
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGV.CurrentRow == null) return;
            int maGV = (int)dgvGV.CurrentRow.Cells["MaGV"].Value;
            if (gvService.Delete(maGV))
            {
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGV.CurrentRow == null) return;
            txtMaGV.Text = dgvGV.CurrentRow.Cells["MaGV"].Value.ToString();
            txtHoTen.Text = dgvGV.CurrentRow.Cells["HoTen"].Value.ToString();
            txtEmail.Text = dgvGV.CurrentRow.Cells["Email"].Value.ToString();

        }
    }
}
