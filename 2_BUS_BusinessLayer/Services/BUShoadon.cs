using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_BusinessLayer.IServices;
using _1_DAL_DataAccessLayer.DALServices;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.Services
{
    public class BUShoadon : IServices.IBUShoadon
    {
        private IDALhoadon daLhoadon;
        private List<Hoadon> _lstHoadons;
        private List<ViewModels> models;

        public BUShoadon()
        {
            daLhoadon = new DALhoadon();
            _lstHoadons = daLhoadon.getlstHD();

        }


        public string AddHD(Hoadon hoadon, string mahoadon, string makhach, string manv, string ngaydathang,
            string tiendatcoc, string trangthai)
        {
            hoadon.Mahoadon = mahoadon;
            hoadon.Makhach = makhach;
            hoadon.Manhanvien = manv;
            hoadon.Ngaydathang = Convert.ToDateTime(ngaydathang);
            hoadon.Tiendatcoc = Convert.ToDecimal(tiendatcoc);
            hoadon.Trangthai = trangthai;

            daLhoadon.AddHD(hoadon);

            return " thanh cong";
        }

        public string UpdateHD(Hoadon hoadon)
        {
            daLhoadon.UpdateHD(hoadon);

            return "thanh cong";
        }

        public string DeleteHD(Hoadon hoadon)
        {
            daLhoadon.DeleteHD(hoadon);
            return " thanh cong";
        }

        public void Save()
        {
            daLhoadon.Save();
        }

        public string AddHDlist(Hoadon hoadon, string mahoadon, string makhach, string manv, string ngaydathang,
            string tiendatcoc, string trangthai)
        {
            hoadon.Mahoadon = mahoadon;
            hoadon.Makhach = makhach;
            hoadon.Manhanvien = manv;
            hoadon.Ngaydathang = Convert.ToDateTime(ngaydathang);
            hoadon.Tiendatcoc = Convert.ToDecimal(tiendatcoc);
            hoadon.Trangthai = trangthai;

            _lstHoadons.Add(hoadon);

            return " thanh cong";

        }

        public string DeleteHDlist(Hoadon hoadon)
        {
            _lstHoadons.Remove(hoadon);
            return " thanh cong";
        }

        public List<Hoadon> getlistHD() 
        {
            return daLhoadon.getlstHD();
        }

        public List<Hoadon> search(string mahoadon)
        {
            throw new NotImplementedException();
        }

        public List<ViewModels> getViewModelsList()
        {
            return models;
        }
    }
}
