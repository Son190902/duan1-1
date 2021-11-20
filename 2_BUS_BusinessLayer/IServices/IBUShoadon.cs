using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IBUShoadon 
    {
        List<Hoadon> getlistHD();

        public string AddHD(Hoadon hoadon, string mahoadon, string makhach, string manv, string ngaydathang,
            string tiendatcoc, string trangthai);

        string DeleteHD(Hoadon hoadon);
        string UpdateHD(Hoadon hoadon);
        List<Hoadon> search(string mahoadon);
        void Save();
        List<ViewModels> getViewModelsList();

        string AddHDlist(Hoadon hoadon, string mahoadon, string makhach, string manv, string ngaydathang,
            string tiendatcoc, string trangthai);

        string DeleteHDlist(Hoadon hoadon);

        
    }
}
