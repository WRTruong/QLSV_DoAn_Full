using System;
using System.IO;
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
        private string currentImagePath = null;

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
                    sv.MaLop,
                    Lop = sv.Lop != null ? sv.Lop.TenLop : "",
                    sv.HinhAnh,
                    sv.TrangThai
                }).ToList();

            dgvSinhVien.Columns["MaLop"].Visible = false;
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

            string gioiTinh = row.Cells["GioiTinh"].Value?.ToString();
            rdNam.Checked = gioiTinh == "Nam";
            rdNu.Checked = gioiTinh == "Nữ";

            cboLop.SelectedValue = Convert.ToInt32(row.Cells["MaLop"].Value);
            chkTrangThai.Checked = Convert.ToBoolean(row.Cells["TrangThai"].Value);

            // Hiển thị ảnh
            string hinhAnh = row.Cells["HinhAnh"].Value?.ToString();
            if (!string.IsNullOrEmpty(hinhAnh))
            {
                string fullPath = Path.Combine(Application.StartupPath, "Images", hinhAnh);
                if (File.Exists(fullPath))
                {
                    pbHinhAnh.ImageLocation = fullPath;
                    currentImagePath = fullPath;
                }
                else
                {
                    pbHinhAnh.Image = null;
                    currentImagePath = null;
                }
            }
            else
            {
                pbHinhAnh.Image = null;
                currentImagePath = null;
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.webp";
                ofd.Title = "Chọn ảnh sinh viên";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbHinhAnh.ImageLocation = ofd.FileName;
                    currentImagePath = ofd.FileName;
                }
            }
        }

        private string SaveImageToFolder(string sourcePath)
        {
            if (string.IsNullOrEmpty(sourcePath) || !File.Exists(sourcePath))
                return null;

            // 🔧 Lấy đường dẫn đến thư mục Images trong GUI (ra khỏi bin\Debug)
            string projectRoot = Directory.GetParent(Application.StartupPath).Parent.FullName;
            string imagesFolder = Path.Combine(projectRoot, "Images");

            if (!Directory.Exists(imagesFolder))
                Directory.CreateDirectory(imagesFolder);

            string fileName = Path.GetFileName(sourcePath);
            string destPath = Path.Combine(imagesFolder, fileName);

            try
            {
                File.Copy(sourcePath, destPath, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu ảnh: " + ex.Message);
                return null;
            }

            return fileName; // Chỉ lưu tên file trong DB
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            string fileName = SaveImageToFolder(currentImagePath);

            var sv = new SinhVien
            {
                HoTen = txtHoTen.Text,
                DiaChi = txtDiaChi.Text,
                Email = txtEmail.Text,
                SDT = txtSDT.Text,
                QueQuan = txtQueQuan.Text,
                GioiTinh = rdNam.Checked,
                MaLop = Convert.ToInt32(cboLop.SelectedValue),
                TrangThai = chkTrangThai.Checked,
                HinhAnh = fileName
            };

            if (svService.Add(sv))
            {
                MessageBox.Show("✅ Thêm sinh viên thành công!");
                LoadSinhVien();
            }
            else
            {
                MessageBox.Show("❌ Thêm thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null) return;

            int maSV = Convert.ToInt32(dgvSinhVien.CurrentRow.Cells["MaSV"].Value);
            var sv = svService.GetById(maSV);
            if (sv == null) return;

            string fileName = SaveImageToFolder(currentImagePath);

            sv.HoTen = txtHoTen.Text;
            sv.DiaChi = txtDiaChi.Text;
            sv.Email = txtEmail.Text;
            sv.SDT = txtSDT.Text;
            sv.QueQuan = txtQueQuan.Text;
            sv.GioiTinh = rdNam.Checked;
            sv.MaLop = Convert.ToInt32(cboLop.SelectedValue);
            sv.TrangThai = chkTrangThai.Checked;
            sv.HinhAnh = fileName;

            if (svService.Update(sv))
            {
                MessageBox.Show("✅ Cập nhật thành công!");
                LoadSinhVien();
            }
            else
            {
                MessageBox.Show("❌ Cập nhật thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null) return;

            int maSV = Convert.ToInt32(dgvSinhVien.CurrentRow.Cells["MaSV"].Value);
            if (svService.Delete(maSV))
            {
                MessageBox.Show("🗑️ Xóa thành công!");
                LoadSinhVien();
            }
            else
            {
                MessageBox.Show("❌ Xóa thất bại!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSinhVien();
        }
    }
}
