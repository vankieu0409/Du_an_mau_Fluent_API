﻿using System.Collections.Generic;
using DAL_QLBH.Entites;

namespace BUS_QLBH.BUS_Interface
{
    public interface IServiceKhachHang_BUS
    {
        public List<KhachHang> GetlissKhachHangs();
        //public List<KH_NV> GetListKaKhachHangs();
        public string Add_Khachhang(KhachHang kh);
        public string Edit_KhachHang(KhachHang kh);
        public string Delete_KhachHang(KhachHang kh);
        public string Save_KhachHang();
    }
}