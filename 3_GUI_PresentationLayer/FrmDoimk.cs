using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;

namespace _3_GUI_PresentationLayer
{
    public partial class FrmDoimk : Form
    {
        private IBUSdoimk buSdoimk;
        public FrmDoimk()
        {
            InitializeComponent();
            buSdoimk = new BUSdoimk();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            Nhanvien nhanvien = new Nhanvien();
            if (txt_newpass.Text == txt_newpass1.Text &&
                buSdoimk.updateMK(nhanvien, txt_Email.Text, txt_oldpass.Text, txt_newpass.Text) == "thanh cong")
            {
                FrmLogin frmLogin = new FrmLogin();
                MessageBox.Show(" doi mat khau thanh cong", "thong bao");
                MessageBox.Show("moi dang nhap lai", "thong bao");
                this.Hide();
                frmLogin.Show();
                return;
            }
            if (txt_newpass.Text != txt_newpass1.Text)
            {
                MessageBox.Show(" mat khau moi khong trung khop", "thong bao");
            }
            else
            {
                MessageBox.Show("mat khau hoac email khong dung", "thong bao");
            }
        }
    }
}
