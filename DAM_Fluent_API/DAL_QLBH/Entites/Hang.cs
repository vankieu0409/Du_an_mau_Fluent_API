﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL_QLBH.Entites
{[Table("HANG")]
    public class Hang
    {
       [Key]
       public int MaHang { get; set; }
        [StringLength(50)]
        public string TenHang { get; set; }
        public int SoLuong { get; set; }
        public double DonGiaBan { get; set; }
        public double DonGiaNhap { get; set; }
     
        [Required]
        [StringLength(20)]
        public string? GhiChu { get; set; }
        [Required]
        public bool trangthai { get; set; }
       
        public string MaNV { get; set; }
        [ForeignKey("MaNV")] public NhanVien KhachHangs { get; set; }
       
    }
}