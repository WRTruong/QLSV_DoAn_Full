using System;
using System.Data;
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
        private readonly LichHocService lichHocService = new LichHocService(); 
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
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*webp";
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
                return null;

            // Thư mục project gốc
            string projectRoot = Directory.GetParent(Application.StartupPath).Parent.FullName;
            string imagesFolder = Path.Combine(projectRoot, "Images");

            // Thư mục chạy thực tế (bin\Debug\Images)
            string debugFolder = Path.Combine(Application.StartupPath, "Images");

            if (!Directory.Exists(imagesFolder))
                Directory.CreateDirectory(imagesFolder);
            if (!Directory.Exists(debugFolder))
                Directory.CreateDirectory(debugFolder);

            string fileName = Path.GetFileName(sourcePath);
            string dest1 = Path.Combine(imagesFolder, fileName);
            string dest2 = Path.Combine(debugFolder, fileName);

            try
            {
                File.Copy(sourcePath, dest1, true);
                File.Copy(sourcePath, dest2, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu ảnh: " + ex.Message);
                return null;
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

        // ---------------- MenuStrip Click ----------------

        private void menuDangKyHoc_Click(object sender, EventArgs e)
        {
            if (_taiKhoan.MaSV.HasValue)
            {
                frmDangKyHoc frm = new frmDangKyHoc(_taiKhoan.Username, _taiKhoan.MaSV.Value);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản chưa gán sinh viên!");
            }
        }

        // ✅ Chỉnh sửa tại đây
        private void menuLichHoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (sinhVien == null || sinhVien.MaLop == null)
                {
                    MessageBox.Show("Bạn chưa được gán vào lớp nào!");
                    return;
                }

                var lichList = lichHocService.GetByLop(sinhVien.MaLop.Value);

                if (lichList.Count == 0)
                {
                    MessageBox.Show("Lớp của bạn hiện chưa có lịch học!");
                    return;
                }

                // Hiển thị trong form popup tạm
                Form frmLich = new Form
                {
                    Text = "📅 Lịch học của lớp " + sinhVien.Lop.TenLop,
                    Width = 800,
                    Height = 400
                };

                DataGridView dgv = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    ReadOnly = true,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    DataSource = lichList.Select(lh => new
                    {
                        Môn_Học = lh.MonHoc?.TenMH, 
                        Giảng_Viên = lh.GiangVien?.HoTen,
                        Học_Kỳ = lh.HocKy?.TenHK, 
                        Thứ = lh.Thu,
                        Từ_Tiết = lh.TietBatDau,
                        Đến_Tiết = lh.TietBatDau + lh.SoTiet - 1, 
                        Số_Tiết = lh.SoTiet,
                        Phòng = "Chưa phân" 
                    }).ToList()
                };

                frmLich.Controls.Add(dgv);
                frmLich.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lịch học: " + ex.Message);
            }
        }


        private void menuDiem_Click(object sender, EventArgs e)
        {
            string role = "SinhVien";
            int? maSV = _taiKhoan.MaSV;
            int? maHK = null; 

            frmDiem frm = new frmDiem(role, maSV, maHK);
            frm.ShowDialog();
        }
        // ---------------- MenuStrip Click ----------------

        private void menuThongBao_Click(object sender, EventArgs e)
        {
            if (!_taiKhoan.MaSV.HasValue)
            {
                MessageBox.Show("Tài khoản này chưa gán sinh viên!");
                return;
            }

            // Mở form Thông báo sinh viên
            frmThongBaoSV frm = new frmThongBaoSV(_taiKhoan.MaSV.Value);
            frm.ShowDialog();
        }

    }
}
