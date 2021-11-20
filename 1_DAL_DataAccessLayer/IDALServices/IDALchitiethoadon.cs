using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IDALServices
{
    public interface IDALchitiethoadon
    {
        void AddCTHD(Chitiethoadon chitiethoadon);
        void UpdateCTHD(Chitiethoadon chitiethoadon);
        void DeleteCTHD(Chitiethoadon chitiethoadon);
        void getListCTHD();
        void Save();
        List<Chitiethoadon> listCTHD();


    }
}
