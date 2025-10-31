using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using QLSV.BUS.Services;
using QLSV.DAL;

namespace QLSV.GUI
{
    public partial class frmSVHome : Form
    {
        private readonly TaiKhoan _taiKhoan;
        private readonly SinhVienService svService = new SinhVienService();
        private SinhVien sinhVien;
        private string currentImagePath = null;

        public frmSVHome(TaiKhoan tk)
        {
            InitializeComponent();
            _taiKhoan = tk;
        }

        private void frmSVHome_Load(object sender, EventArgs e)
        {
            InitLabelsAndTextboxes();
            if (!_taiKhoan.MaSV.HasValue)
            {
                MessageBox.Show("Tài khoản này chưa gán sinh viên!");
                this.Close();
                return;
            }

            sinhVien = svService.GetById(_taiKhoan.MaSV.Value);
            if (sinhVien == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên!");
                this.Close();
                return;
            }

            LoadThongTinCaNhan();
        }

        private void LoadThongTinCaNhan()
        {
            txtHoTen.Text = sinhVien.HoTen;
            txtGioiTinh.Text = sinhVien.GioiTinh.HasValue ? (sinhVien.GioiTinh.Value ? "Nam" : "Nữ") : "";
            dtpNgaySinh.Value = sinhVien.NgaySinh ?? DateTime.Now;
            txtEmail.Text = sinhVien.Email;
            txtSDT.Text = sinhVien.SDT;
            txtDiaChi.Text = sinhVien.DiaChi;
            txtQueQuan.Text = sinhVien.QueQuan;
            txtTonGiao.Text = sinhVien.TonGiao;
            txtHocLuc.Text = sinhVien.HocLuc;
            txtHocPhi.Text = sinhVien.HocPhi.HasValue ? sinhVien.HocPhi.Value.ToString("N0") : "";
            txtTrangThai.Text = sinhVien.TrangThai.HasValue ? (sinhVien.TrangThai.Value ? "Đang học" : "Nghỉ học") : "";
            txtLop.Text = sinhVien.Lop != null ? sinhVien.Lop.TenLop : "";

            if (!string.IsNullOrEmpty(sinhVien.HinhAnh))
            {
                string fullPath = Path.Combine(Application.StartupPath, "Images", sinhVien.HinhAnh);
                if (File.Exists(fullPath))
                {
                    picAnh.ImageLocation = fullPath;
                    currentImagePath = fullPath;
                }
                else
                {
                    picAnh.Image = null;
                    currentImagePath = null;
                }
            }
            else
            {
                picAnh.Image = null;
                currentImagePath = null;
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Chọn ảnh sinh viên";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picAnh.ImageLocation = ofd.FileName;
                    currentImagePath = ofd.FileName;
                }
            }
        }

        private string SaveImageToFolder(string sourcePath)
        {
            if (string.IsNullOrEmpty(sourcePath) || !File.Exists(sourcePath))
                return sinhVien.HinhAnh; // giữ nguyên ảnh cũ

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
                return sinhVien.HinhAnh;
            }

            return fileName;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                sinhVien.HoTen = txtHoTen.Text;
                sinhVien.Email = txtEmail.Text;
                sinhVien.SDT = txtSDT.Text;
                sinhVien.DiaChi = txtDiaChi.Text;
                sinhVien.QueQuan = txtQueQuan.Text;
                sinhVien.TonGiao = txtTonGiao.Text;
                sinhVien.HocLuc = txtHocLuc.Text;

                if (decimal.TryParse(txtHocPhi.Text, out decimal hocPhi))
                    sinhVien.HocPhi = (double)hocPhi;
                else
                    sinhVien.HocPhi = null;


                sinhVien.GioiTinh = txtGioiTinh.Text == "Nam" ? true :
                                    txtGioiTinh.Text == "Nữ" ? false : (bool?)null;

                sinhVien.NgaySinh = dtpNgaySinh.Value;

                if (txtTrangThai.Text == "Đang học") sinhVien.TrangThai = true;
                else if (txtTrangThai.Text == "Nghỉ học") sinhVien.TrangThai = false;

                sinhVien.HinhAnh = SaveImageToFolder(currentImagePath);

                if (svService.Update(sinhVien))
                {
                    MessageBox.Show("✅ Cập nhật thông tin thành công!");
                    LoadThongTinCaNhan();
                }
                else
                {
                    MessageBox.Show("❌ Cập nhật thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu thông tin: " + ex.Message);
            }
        }
    }
}
