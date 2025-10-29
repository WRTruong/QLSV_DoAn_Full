using System;
using System.Linq;
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
            LoadComboBox();
            LoadData();
        }

        private void LoadComboBox()
        {
            cboKhoa.DataSource = khoaService.GetAll();
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
        }

        private void LoadData()
        {
            dgvLop.DataSource = lopService.GetAll()
                .Select(l => new
                {
                    l.MaLop,
                    l.TenLop,
                    TenKhoa = l.Khoa.TenKhoa
                }).ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var lop = new Lop
            {
                TenLop = txtTenLop.Text,
                MaKhoa = (int)cboKhoa.SelectedValue
            };
            if (lopService.Add(lop))
            {
                MessageBox.Show("Thêm thành công!");
                LoadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLop.CurrentRow == null) return;

            int maLop = (int)dgvLop.CurrentRow.Cells["MaLop"].Value;
            var lop = lopService.GetById(maLop);
            lop.TenLop = txtTenLop.Text;
            lop.MaKhoa = (int)cboKhoa.SelectedValue;
            if (lopService.Update(lop))
            {
                MessageBox.Show("Sửa thành công!");
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLop.CurrentRow == null) return;
            int maLop = (int)dgvLop.CurrentRow.Cells["MaLop"].Value;
            if (lopService.Delete(maLop))
            {
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLop.CurrentRow == null) return;

            txtMaLop.Text = dgvLop.CurrentRow.Cells["MaLop"].Value.ToString();
            txtTenLop.Text = dgvLop.CurrentRow.Cells["TenLop"].Value.ToString();
            cboKhoa.SelectedValue = lopService.GetById((int)dgvLop.CurrentRow.Cells["MaLop"].Value).MaKhoa;
        }
    }
}
