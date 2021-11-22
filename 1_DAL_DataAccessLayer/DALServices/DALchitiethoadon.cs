using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.DALServices
{
    public class DALchitiethoadon : IDALchitiethoadon
    {
        private List<Chitiethoadon> chitiethoadons = new List<Chitiethoadon>();
        private DatabaseContext databaseContext;

        public DALchitiethoadon()
        {
            databaseContext = new DatabaseContext();
            getListCTHD();
        }

        public void getListCTHD()
        {
            chitiethoadons = databaseContext.Chitiethoadons.ToList();
        }

        public List<Chitiethoadon> listCTHD()
        {
            return chitiethoadons;
        }

        public void AddCTHD(Chitiethoadon chitiethoadon)
        {
            databaseContext.Chitiethoadons.Add(chitiethoadon);
            databaseContext.SaveChanges();
            getListCTHD();
        }
        public void UpdateCTHD(Chitiethoadon chitiethoadon)
        {
            databaseContext.Chitiethoadons.Update(chitiethoadon);
            databaseContext.SaveChanges();
            getListCTHD();
        }
        public void DeleteCTHD(Chitiethoadon chitiethoadon)
        {
            databaseContext.Chitiethoadons.Remove(chitiethoadon);
            databaseContext.SaveChanges();
            getListCTHD();
        }

        public void Save()
        {
            databaseContext.SaveChanges();
        }
    }
}
