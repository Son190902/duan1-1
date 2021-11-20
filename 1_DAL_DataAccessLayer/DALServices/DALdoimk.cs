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
    public class DALdoimk : IDALdoimk
    {
        private DatabaseContext databaseContext;
        private List<Nhanvien> nhanviens;

        public DALdoimk()
        {
            databaseContext = new DatabaseContext();
            nhanviens = new List<Nhanvien>();
            getlstfromDB();
        }

        public void getlstfromDB()
        {
            nhanviens = databaseContext.Nhanviens.ToList();
        }

        public List<Nhanvien> GetList()
        {
            return nhanviens;
        }

        public void doimk(Nhanvien nhanvien)
        {
            databaseContext.Nhanviens.Update(nhanvien);
            databaseContext.SaveChanges();
        }
    }
}
