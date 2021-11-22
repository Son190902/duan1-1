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
    public class DALhoadon : IDALhoadon
    {
        private DatabaseContext databaseContext;
        private List<Hoadon> hoadons;

        public DALhoadon()
        {
            databaseContext = new DatabaseContext();
            hoadons = new List<Hoadon>();
            getlstfromdb();

        }

        public void getlstfromdb()
        {
            hoadons = databaseContext.Hoadons.ToList();
        }

        public List<Hoadon> getlstHD()
        {
            return hoadons;
        }

        public void AddHD(Hoadon hoadon)
        {
            databaseContext.Hoadons.Add(hoadon);
            databaseContext.SaveChanges();
        }

        public void DeleteHD(Hoadon hoadon)
        {
            databaseContext.Hoadons.Remove(hoadon);
            databaseContext.SaveChanges();

        }

        public void UpdateHD(Hoadon hoadon)
        {
            databaseContext.Hoadons.Update(hoadon);
            databaseContext.SaveChanges();

        }

        public void Save()
        {
            databaseContext.SaveChanges();
        }
    }
    
}
