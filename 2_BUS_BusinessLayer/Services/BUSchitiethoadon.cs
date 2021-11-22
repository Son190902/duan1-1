using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.DALServices;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.Services
{
    public class BUSchitiethoadon : IBUSchitiethoadon
    {
        private DALchitiethoadon daLchitiethoadon;
        private List<Chitiethoadon> _lstChitiethoadons;
        private List<ViewModels> models;

        public BUSchitiethoadon()
        {
            daLchitiethoadon = new DALchitiethoadon();
            _lstChitiethoadons = daLchitiethoadon.listCTHD();
        }


        public string AddCTHD(Chitiethoadon chitiethoadon, string maCTHD, string mahoadon, string mactsanpham,
            string madichvu, string soluong, string dongia, string ngaygiaohang, string tongtienthanhtoan, string trangthai)
        {
            chitiethoadon.MaCtdh = maCTHD;
            chitiethoadon.Mahoadon = mahoadon;
            chitiethoadon.Mactsanpham = mactsanpham;
            chitiethoadon.Madichvu = madichvu;
            chitiethoadon.Soluong = Convert.ToInt32(soluong);
            chitiethoadon.Dongia = Convert.ToDecimal(dongia);
            chitiethoadon.Ngaygiaohang = Convert.ToDateTime(ngaygiaohang);
            chitiethoadon.Tongtienthanhtoan = Convert.ToDecimal(dongia) * Convert.ToInt32(soluong);
            chitiethoadon.Trangthai = trangthai;
            daLchitiethoadon.AddCTHD(chitiethoadon);
            return " thanh cong";
        }

        public string UpdateHD(Chitiethoadon chitiethoadon)
        {
            daLchitiethoadon.UpdateCTHD(chitiethoadon);

            return "thanh cong";
        }

        public string DeleteHD(Chitiethoadon chitiethoadon)
        {
            daLchitiethoadon.DeleteCTHD(chitiethoadon);
            return "thanh cong";
        }
        public void Save()
        {
            daLchitiethoadon.Save();
        }

        string AddCTHDlist(Chitiethoadon chitiethoadon, string maCTHD, string mahoadon, string mactsanpham,
            string madichvu, string soluong, string dongia, string ngaygiaohang, string tongtienthanhtoan, string trangthai)
        {
            chitiethoadon.MaCtdh = maCTHD;
            chitiethoadon.Mahoadon = mahoadon;
            chitiethoadon.Mactsanpham = mactsanpham;
            chitiethoadon.Madichvu = madichvu;
            chitiethoadon.Soluong = Convert.ToInt32(soluong);
            chitiethoadon.Dongia = Convert.ToDecimal(dongia);
            chitiethoadon.Ngaygiaohang = Convert.ToDateTime(ngaygiaohang);
            chitiethoadon.Tongtienthanhtoan = Convert.ToDecimal(tongtienthanhtoan);
            chitiethoadon.Trangthai = trangthai;

            return " thanh cong";

        }

        public List<Chitiethoadon> getlistCTHD()
        {
            return daLchitiethoadon.listCTHD();
        }

        public string DeleteCTHD(Chitiethoadon chitiethoadon)
        {
            _lstChitiethoadons.Remove(chitiethoadon);
            return " thanh cong";
        }

        public string UpdateCTHD(Chitiethoadon chitiethoadon)
        {
            _lstChitiethoadons.Remove(chitiethoadon);
            return " thanh cong";
        }

        string IBUSchitiethoadon.AddCTHDlist(Chitiethoadon chitiethoadon, string maCTHD, string mahoadon, string mactsanpham,
            string madichvu, string soluong, string dongia, string ngaygiaohang, string tongtienthanhtoan, string trangthai)
        {
            throw new NotImplementedException();
        }
    }
}
