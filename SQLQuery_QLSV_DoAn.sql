create database QLSV_DoAn
go
use QLSV_DoAn
go

-- ============================================
-- 1. Bảng Khoa
-- ============================================
CREATE TABLE Khoa (
    MaKhoa int IDENTITY(1,1) PRIMARY KEY,
    TenKhoa nvarchar(100) NOT NULL
);

INSERT INTO Khoa (TenKhoa) VALUES
('Công nghệ thông tin'),
('Điện tử viễn thông'),
('Kinh tế'),
('Quản trị kinh doanh'),
('Cơ khí');

-- ============================================
-- 2. Bảng Lop
-- ============================================
CREATE TABLE Lop (
    MaLop int IDENTITY(1,1) PRIMARY KEY,
    TenLop nvarchar(100) NOT NULL,
    MaKhoa int NOT NULL FOREIGN KEY REFERENCES Khoa(MaKhoa)
);

INSERT INTO Lop (TenLop, MaKhoa) VALUES
('CTK38', 1),
('CTK39', 1),
('DTVT38', 2),
('KTK38', 3),
('QTK38', 4);

-- ============================================
-- 3. Bảng GiangVien
-- ============================================
CREATE TABLE GiangVien (
    MaGV int IDENTITY(1,1) PRIMARY KEY,
    HoTen nvarchar(100) NOT NULL,
    GioiTinh bit,
    NgaySinh date,
    ChuyenNganh nvarchar(100),
    DiaChi nvarchar(200),
    Email nvarchar(100)
);

INSERT INTO GiangVien (HoTen, GioiTinh, NgaySinh, ChuyenNganh, DiaChi, Email) VALUES
('Nguyễn Văn A', 1, '1980-05-10', 'CNTT', 'Hà Nội', 'nga@example.com'),
('Trần Thị B', 0, '1982-08-20', 'Điện tử', 'Hải Phòng', 'ttb@example.com'),
('Lê Văn C', 1, '1978-11-15', 'Kinh tế', 'Hà Nội', 'lvc@example.com'),
('Phạm Thị D', 0, '1985-02-28', 'Quản trị kinh doanh', 'Đà Nẵng', 'ptd@example.com'),
('Hoàng Văn E', 1, '1981-07-07', 'Cơ khí', 'TP.HCM', 'hve@example.com');

-- ============================================
-- 4. Bảng MonHoc
-- ============================================
CREATE TABLE MonHoc (
    MaMH int IDENTITY(1,1) PRIMARY KEY,
    TenMH nvarchar(100) NOT NULL,
    SoTC int
);

INSERT INTO MonHoc (TenMH, SoTC) VALUES
('Toán cao cấp', 3),
('Lập trình C#', 4),
('Cơ sở dữ liệu', 3),
('Mạng máy tính', 3),
('Điện tử cơ bản', 3),
('Quản trị kinh doanh', 3),
('Kinh tế vi mô', 3),
('Cơ khí ứng dụng', 4),
('Tiếng Anh chuyên ngành', 2),
('Pháp luật đại cương', 2);

-- ============================================
-- 5. Bảng SinhVien
-- ============================================
CREATE TABLE SinhVien (
    MaSV int IDENTITY(1,1) PRIMARY KEY,
    HoTen nvarchar(100) NOT NULL,
    GioiTinh bit,
    NgaySinh date,
    DiaChi nvarchar(200),
    QueQuan nvarchar(100),
    SDT nvarchar(20),
    Email nvarchar(100),
    MaLop int FOREIGN KEY REFERENCES Lop(MaLop),
    NgayVaoTruong date,
    HinhAnh nvarchar(255),
    CMND nvarchar(20),
    DanToc nvarchar(50),
    TonGiao nvarchar(50),
    HocLuc nvarchar(20),
    HocPhi float,
    TrangThai bit
);

INSERT INTO SinhVien (HoTen, GioiTinh, NgaySinh, DiaChi, QueQuan, SDT, Email, MaLop, NgayVaoTruong, HinhAnh, CMND, DanToc, TonGiao, HocLuc, HocPhi, TrangThai) VALUES
('Nguyễn Văn 1',1,'2003-01-01','Hà Nội','Hà Nội','0901000001','sv1@example.com',1,'2021-09-01','Images/sv1.jpg','001','Kinh','Không','Khá',10000000,1),
('Nguyễn Văn 2',1,'2003-02-02','Hà Nội','Hà Nội','0901000002','sv2@example.com',1,'2021-09-01','Images/sv2.jpg','002','Kinh','Không','Giỏi',10000000,1),
('Trần Thị 3',0,'2003-03-03','Hải Phòng','Hải Phòng','0901000003','sv3@example.com',2,'2021-09-01','Images/sv3.jpg','003','Kinh','Không','TB',10000000,1),
('Lê Văn 4',1,'2003-04-04','Hà Nội','Hà Nội','0901000004','sv4@example.com',2,'2021-09-01','Images/sv4.jpg','004','Kinh','Không','Khá',10000000,1),
('Phạm Thị 5',0,'2003-05-05','Đà Nẵng','Đà Nẵng','0901000005','sv5@example.com',3,'2021-09-01','Images/sv5.jpg','005','Kinh','Không','Giỏi',10000000,1),
('Nguyễn Văn 6',1,'2003-06-06','Hà Nội','Hà Nội','0901000006','sv6@example.com',3,'2021-09-01','Images/sv6.jpg','006','Kinh','Không','TB',10000000,1),
('Hoàng Thị 7',0,'2003-07-07','TP.HCM','TP.HCM','0901000007','sv7@example.com',4,'2021-09-01','Images/sv7.jpg','007','Kinh','Không','Khá',10000000,1),
('Lê Thị 8',0,'2003-08-08','Đà Nẵng','Đà Nẵng','0901000008','sv8@example.com',4,'2021-09-01','Images/sv8.jpg','008','Kinh','Không','Giỏi',10000000,1),
('Phạm Văn 9',1,'2003-09-09','Hải Phòng','Hải Phòng','0901000009','sv9@example.com',5,'2021-09-01','Images/sv9.jpg','009','Kinh','Không','TB',10000000,1),
('Trần Văn 10',1,'2003-10-10','Hà Nội','Hà Nội','0901000010','sv10@example.com',5,'2021-09-01','Images/sv10.jpg','010','Kinh','Không','Khá',10000000,1),
('Nguyễn Văn 11',1,'2003-11-11','Hà Nội','Hà Nội','0901000011','sv11@example.com',1,'2021-09-01','Images/sv11.jpg','011','Kinh','Không','Giỏi',10000000,1),
('Nguyễn Văn 12',1,'2003-12-12','Hà Nội','Hà Nội','0901000012','sv12@example.com',1,'2021-09-01','Images/sv12.jpg','012','Kinh','Không','TB',10000000,1),
('Trần Thị 13',0,'2003-01-13','Hải Phòng','Hải Phòng','0901000013','sv13@example.com',2,'2021-09-01','Images/sv13.jpg','013','Kinh','Không','Khá',10000000,1),
('Lê Văn 14',1,'2003-02-14','Hà Nội','Hà Nội','0901000014','sv14@example.com',2,'2021-09-01','Images/sv14.jpg','014','Kinh','Không','Giỏi',10000000,1),
('Phạm Thị 15',0,'2003-03-15','Đà Nẵng','Đà Nẵng','0901000015','sv15@example.com',3,'2021-09-01','Images/sv15.jpg','015','Kinh','Không','Khá',10000000,1),
('Nguyễn Văn 16',1,'2003-04-16','Hà Nội','Hà Nội','0901000016','sv16@example.com',3,'2021-09-01','Images/sv16.jpg','016','Kinh','Không','TB',10000000,1),
('Hoàng Thị 17',0,'2003-05-17','TP.HCM','TP.HCM','0901000017','sv17@example.com',4,'2021-09-01','Images/sv17.jpg','017','Kinh','Không','Giỏi',10000000,1),
('Lê Thị 18',0,'2003-06-18','Đà Nẵng','Đà Nẵng','0901000018','sv18@example.com',4,'2021-09-01','Images/sv18.jpg','018','Kinh','Không','Khá',10000000,1),
('Phạm Văn 19',1,'2003-07-19','Hải Phòng','Hải Phòng','0901000019','sv19@example.com',5,'2021-09-01','Images/sv19.jpg','019','Kinh','Không','Giỏi',10000000,1),
('Trần Văn 20',1,'2003-08-20','Hà Nội','Hà Nội','0901000020','sv20@example.com',5,'2021-09-01','Images/sv20.jpg','020','Kinh','Không','Khá',10000000,1);

-- ============================================
-- 6. Bảng HocKy
-- ============================================
CREATE TABLE HocKy (
    MaHK int IDENTITY(1,1) PRIMARY KEY,
    TenHK nvarchar(50) NOT NULL,
    NamHoc nvarchar(20) NOT NULL
);

INSERT INTO HocKy (TenHK, NamHoc) VALUES
('HK1', '2025-2026'),
('HK2', '2025-2026');

-- ============================================
-- 7. Bảng LichHoc
-- ============================================
CREATE TABLE LichHoc (
    MaLop int NOT NULL FOREIGN KEY REFERENCES Lop(MaLop),
    MaMH int NOT NULL FOREIGN KEY REFERENCES MonHoc(MaMH),
    MaGV int NOT NULL FOREIGN KEY REFERENCES GiangVien(MaGV),
    MaHK int NOT NULL FOREIGN KEY REFERENCES HocKy(MaHK),
    Thu nvarchar(10) NOT NULL,
    TietBatDau int NOT NULL,
    SoTiet int NOT NULL,
    PRIMARY KEY(MaLop, MaMH, MaHK)
);

-- Dữ liệu mẫu LichHoc
INSERT INTO LichHoc (MaLop, MaMH, MaGV, MaHK, Thu, TietBatDau, SoTiet) VALUES
(1,2,1,1,'Thứ 2',1,3),
(1,3,1,1,'Thứ 3',4,2),
(2,2,2,1,'Thứ 2',1,3),
(2,4,2,1,'Thứ 4',5,2),
(3,5,3,1,'Thứ 3',2,3),
(3,6,3,1,'Thứ 5',1,2),
(4,7,4,1,'Thứ 2',3,3),
(4,8,4,1,'Thứ 4',2,2),
(5,9,5,1,'Thứ 3',1,2),
(5,10,5,1,'Thứ 5',3,2);

-- ============================================
-- 8. Bảng DangKyHoc
-- ============================================
CREATE TABLE DangKyHoc (
    MaSV int NOT NULL FOREIGN KEY REFERENCES SinhVien(MaSV),
    MaMH int NOT NULL FOREIGN KEY REFERENCES MonHoc(MaMH),
    MaHK int NOT NULL FOREIGN KEY REFERENCES HocKy(MaHK),
    PRIMARY KEY(MaSV, MaMH, MaHK)
);

-- Dữ liệu mẫu đăng ký học
INSERT INTO DangKyHoc (MaSV, MaMH, MaHK) VALUES
(1,2,1),(1,3,1),(2,2,1),(2,3,1),(3,5,1),(3,6,1),(4,7,1),(4,8,1),
(5,9,1),(5,10,1),(6,2,1),(6,3,1),(7,5,1),(7,6,1),(8,7,1),(8,8,1),
(9,9,1),(9,10,1),(10,2,1),(10,3,1);

-- ============================================
-- 9. Bảng Diem
-- ============================================
CREATE TABLE Diem (
    MaSV int NOT NULL FOREIGN KEY REFERENCES SinhVien(MaSV),
    MaMH int NOT NULL FOREIGN KEY REFERENCES MonHoc(MaMH),
    DiemQT float,
    DiemCK float,
    DiemTong float,
    PRIMARY KEY(MaSV, MaMH)
);

-- Dữ liệu mẫu điểm
INSERT INTO Diem (MaSV, MaMH, DiemQT, DiemCK, DiemTong) VALUES
(1,2,7.5,8.0,7.8),
(1,3,6.5,7.0,6.8),
(2,2,8.0,8.5,8.2),
(2,3,7.0,7.5,7.2),
(3,5,6.0,6.5,6.2),
(3,6,7.0,7.5,7.2),
(4,7,8.0,8.5,8.2),
(4,8,7.5,7.0,7.2),
(5,9,6.5,7.0,6.8),
(5,10,7.0,7.5,7.2);

-- ============================================
-- 10. Bảng TaiKhoan
-- ============================================
CREATE TABLE TaiKhoan (
    MaTK int IDENTITY(1,1) PRIMARY KEY,
    Username nvarchar(50) NOT NULL,
    Password nvarchar(255) NOT NULL,
    LoaiTK nvarchar(20) NOT NULL,
    MaSV int NULL FOREIGN KEY REFERENCES SinhVien(MaSV),
    MaGV int NULL FOREIGN KEY REFERENCES GiangVien(MaGV)
);

INSERT INTO TaiKhoan (Username, Password, LoaiTK, MaSV, MaGV) VALUES
('admin','admin123','Admin',NULL,NULL),
('gv1','123','GiangVien',NULL,1),
('gv2','123','GiangVien',NULL,2),
('sv1','123','SinhVien',1,NULL),
('sv2','123','SinhVien',2,NULL);

-- ============================================
-- 11. Bảng Quyen
-- ============================================
CREATE TABLE Quyen (
    MaQuyen int IDENTITY(1,1) PRIMARY KEY,
    TenQuyen nvarchar(50)
);

INSERT INTO Quyen (TenQuyen) VALUES
('Xem'),('Them'),('Sua'),('Xoa');

-- ============================================
-- 12. Bảng TaiKhoan_Quyen
-- ============================================
CREATE TABLE TaiKhoan_Quyen (
    MaTK int NOT NULL FOREIGN KEY REFERENCES TaiKhoan(MaTK),
    MaQuyen int NOT NULL FOREIGN KEY REFERENCES Quyen(MaQuyen),
    PRIMARY KEY(MaTK, MaQuyen)
);

-- Dữ liệu mẫu gán quyền
INSERT INTO TaiKhoan_Quyen (MaTK, MaQuyen) VALUES
(1,1),(1,2),(1,3),(1,4), -- Admin tất cả quyền
(2,1),(2,3),              -- GV1 xem và sửa
(3,1),(3,3),              -- GV2 xem và sửa
(4,1),                    -- SV1 chỉ xem
(5,1);                    -- SV2 chỉ xem

-- ============================================
-- 13. Bảng ThongBao
-- ============================================
CREATE TABLE ThongBao (
    MaTB int IDENTITY(1,1) PRIMARY KEY,
    TieuDe nvarchar(100),
    NoiDung nvarchar(MAX),
    NgayTB datetime,
    MaLop int NULL FOREIGN KEY REFERENCES Lop(MaLop),
    MaTK int NULL FOREIGN KEY REFERENCES TaiKhoan(MaTK)
);

INSERT INTO ThongBao (TieuDe, NoiDung, NgayTB, MaLop, MaTK) VALUES
('Thông báo học phí','Sinh viên vui lòng nộp học phí trước 30/10',GETDATE(),NULL,NULL),
('Lịch thi','Lịch thi môn C#',GETDATE(),1,NULL),
('Thông báo riêng','Bạn cần bổ sung hồ sơ',GETDATE(),NULL,4);

-- ============================================
-- 14. Bảng LogHoatDong
-- ============================================
CREATE TABLE LogHoatDong (
    MaLog int IDENTITY(1,1) PRIMARY KEY,
    MaTK int NOT NULL FOREIGN KEY REFERENCES TaiKhoan(MaTK),
    ThoiGian datetime,
    HanhDong nvarchar(255),
    BangLienQuan nvarchar(50),
    MaLienQuan int
);

-- Dữ liệu mẫu log
INSERT INTO LogHoatDong (MaTK, ThoiGian, HanhDong, BangLienQuan, MaLienQuan) VALUES
(1,GETDATE(),'Thêm sinh viên','SinhVien',1),
(2,GETDATE(),'Cập nhật điểm','Diem',1),
(4,GETDATE(),'Xem điểm','Diem',1);



CREATE VIEW vw_QuanLySinhVien AS
SELECT 
    sv.MaSV, sv.HoTen AS TenSV, sv.GioiTinh, sv.NgaySinh, sv.Email AS EmailSV,
    l.TenLop, k.TenKhoa,
    gv.MaGV, gv.HoTen AS TenGV, gv.ChuyenNganh,
    mh.MaMH, mh.TenMH, mh.SoTC,
    hk.MaHK, hk.TenHK, hk.NamHoc,
    d.DiemQT, d.DiemCK, d.DiemTong,
    tk.MaTK, tk.Username, tk.LoaiTK,
    q.TenQuyen,
    tb.MaTB, tb.TieuDe AS TieuDeTB, tb.NoiDung AS NoiDungTB, tb.NgayTB,
    log.MaLog, log.HanhDong AS HanhDongLog, log.ThoiGian AS ThoiGianLog
FROM SinhVien sv
LEFT JOIN Lop l ON sv.MaLop = l.MaLop
LEFT JOIN Khoa k ON l.MaKhoa = k.MaKhoa
LEFT JOIN DangKyHoc dk ON sv.MaSV = dk.MaSV
LEFT JOIN MonHoc mh ON dk.MaMH = mh.MaMH
LEFT JOIN HocKy hk ON dk.MaHK = hk.MaHK
LEFT JOIN Diem d ON sv.MaSV = d.MaSV AND mh.MaMH = d.MaMH
LEFT JOIN TaiKhoan tk ON sv.MaSV = tk.MaSV
LEFT JOIN TaiKhoan_Quyen tkq ON tk.MaTK = tkq.MaTK
LEFT JOIN Quyen q ON tkq.MaQuyen = q.MaQuyen
LEFT JOIN ThongBao tb ON sv.MaLop = tb.MaLop OR tk.MaTK = tb.MaTK
LEFT JOIN LogHoatDong log ON tk.MaTK = log.MaTK
LEFT JOIN GiangVien gv ON mh.MaMH = gv.MaGV; -- tạm join GV theo môn học nếu muốn

select * from Quyen;
select * from TaiKhoan_Quyen;
select * from TaiKhoan;
