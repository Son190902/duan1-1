using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IBUSchitiethoadon
    {
        List<Chitiethoadon> getlistCTHD();

        public string AddCTHD(Chitiethoadon chitiethoadon, string maCTHD, string mahoadon, string mactsanpham,
            string madichvu, string soluong, string dongia, string ngaygiaohang, string tongtienthanhtoan, string trangthai);

        string DeleteHD(Chitiethoadon chitiethoadon);
        string UpdateHD(Chitiethoadon chitiethoadon);
        void Save();
        //List<ViewModels> getViewModelsList();

        string AddCTHDlist(Chitiethoadon chitiethoadon, string maCTHD, string mahoadon, string mactsanpham, 
            string madichvu, string soluong, string dongia, string ngaygiaohang, string tongtienthanhtoan, string trangthai);

    }
}
