using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.DALServices;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;

namespace _2_BUS_BusinessLayer.Services
{
    public class BUSdoimk : IBUSdoimk
    {
        private IDALdoimk daLdoimk;

        public BUSdoimk()
        {
            daLdoimk = new DALdoimk();
        }
        public string updateMK(Nhanvien nhanvien, string email, string oldpass, string newpass)
        {
            nhanvien = daLdoimk.GetList().Where(c=>c.Email == email).FirstOrDefault();
            if (nhanvien.Matkhau == mahoa(oldpass))
            {
                nhanvien.Matkhau = mahoa(newpass);
                daLdoimk.doimk(nhanvien);
                return "thanh cong";
            }
            return "email hoac mat khau khong dung";
        }

        public string updateMKNV(Nhanvien nhanvien, string email, string oldpass, string newpass)
        {
            nhanvien = daLdoimk.GetList().Where(c => c.Email == email).FirstOrDefault();
            if (nhanvien.Matkhau == oldpass)
            {
                nhanvien.Matkhau = newpass;
                daLdoimk.doimk(nhanvien);
                return "thanh cong";
            }
            return "email hoac mat khau khong dung";
        }

        public string mahoa(string pass)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] enctypt;
            UTF8Encoding encode = new UTF8Encoding();
            enctypt = md5.ComputeHash(encode.GetBytes(pass));
            StringBuilder encriptdata = new StringBuilder();
            for (int i = 0; i < enctypt.Length; i++)
            {
                encriptdata.Append(enctypt[i].ToString());
            }
            return encriptdata.ToString();
        }
    }
}
