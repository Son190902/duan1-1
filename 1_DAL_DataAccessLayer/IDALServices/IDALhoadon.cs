using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IDALServices
{
    public interface IDALhoadon
    {
        List<Hoadon> getlstHD();
        void AddHD(Hoadon hoadon);
        void DeleteHD(Hoadon hoadon);
        void UpdateHD(Hoadon hoadon);
        void Save();
        void getlstfromdb();
    }
}
