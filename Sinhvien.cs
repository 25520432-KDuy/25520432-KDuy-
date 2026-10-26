using System;

namespace Lab02_FileIO_NguyenKhanhDuy_25520432
{
    // Thêm [Serializable] để chuẩn bị cho việc ghi file (nếu cần)
    [Serializable]
    public class SinhVien
    {
        public string HoTen { get; set; }
        public string MSSV { get; set; }
        public string DienThoai { get; set; }
        public float DiemMon1 { get; set; }
        public float DiemMon2 { get; set; }
        public float DiemMon3 { get; set; }

        // Thuộc tính tính điểm trung bình (chỉ đọc)
        public float DiemTrungBinh
        {
            get { return (DiemMon1 + DiemMon2 + DiemMon3) / 3; }
        }

        // Hàm khởi tạo không tham số (Bắt buộc phải có để thư viện Json đọc file)
        public SinhVien() { }

        // Hàm khởi tạo có tham số (Dùng khi bấm nút Add)
        public SinhVien(string hoTen, string mssv, string dienThoai, float d1, float d2, float d3)
        {
            HoTen = hoTen;
            MSSV = mssv;
            DienThoai = dienThoai;
            DiemMon1 = d1;
            DiemMon2 = d2;
            DiemMon3 = d3;
        }
    }
}