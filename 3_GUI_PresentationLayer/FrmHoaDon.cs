using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;

namespace _3_GUI_PresentationLayer
{
    
    public partial class FrmHoaDon : Form
    {
        
        private IBUShoadon _BUShoadon;
        private string idhoadon;

        public FrmHoaDon()
        {
            InitializeComponent();
            _BUShoadon = new BUShoadon();
            loadData();
        }

        public void loadData()
        {
            dgrv_dsphieunhap.ColumnCount = 7;
            dgrv_dsphieunhap.Columns[0].Name = "ma hoa don";
            dgrv_dsphieunhap.Columns[1].Name = "ma khach";
            dgrv_dsphieunhap.Columns[2].Name = "ma nhan vien";
            dgrv_dsphieunhap.Columns[3].Name = "ngay lap hoa don";
            dgrv_dsphieunhap.Columns[4].Name = "tien dat coc";
            dgrv_dsphieunhap.Columns[5].Name = "trang thai";
            dgrv_dsphieunhap.Columns[6].Name = "dia chi";
            dgrv_dsphieunhap.Rows.Clear();
            foreach (var x in _BUShoadon.getlistHD()) // 
            {
                dgrv_dsphieunhap.Rows.Add(x.Mahoadon, x.Makhach, x.Manhanvien, x.Ngaydathang,
                    x.Tiendatcoc, x.Trangthai, x.Ngaydathang);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            Hoadon hoadon = new Hoadon();

            hoadon.Mahoadon = txt_mahd.Text;
            hoadon.Makhach = txt_makh.Text;
            hoadon.Manhanvien = txt_manv.Text;
            hoadon.Ngaydathang = Convert.ToDateTime(txt_ngaylaphd.Text);
            hoadon.Tiendatcoc = Convert.ToDecimal(txt_tiendatcoc.Text);
            if (hoadon.Trangthai == "con hang")
            {
                chk_conhang.Checked = true;
            }
            if (hoadon.Trangthai == "het hang")
            {

                chk_hethang.Checked = true;
            }
            _BUShoadon.AddHD(hoadon,txt_mahd.Text,txt_makh.Text,txt_manv.Text,txt_ngaylaphd.Text,txt_tiendatcoc.Text,chk_conhang.Checked.ToString()); //truyền vào đúng như cái vừa hiện
            MessageBox.Show("them thanh cong", "thong bao"); 
            _BUShoadon.getlistHD();
            
            loadData();
        }

        private void dgrv_dsphieunhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if(i == _BUShoadon.getlistHD().Count) return;
            // idhoadon = dgrv_dsphieunhap.Rows[i].Cells[0].Value.ToString();
            txt_mahd.Text = dgrv_dsphieunhap.Rows[i].Cells[0].Value.ToString();
            txt_makh.Text = dgrv_dsphieunhap.Rows[i].Cells[1].Value.ToString(); 
            txt_manv.Text = dgrv_dsphieunhap.Rows[i].Cells[2].Value.ToString(); 
            txt_ngaylaphd.Text = dgrv_dsphieunhap.Rows[i].Cells[3].Value.ToString(); 
            txt_tiendatcoc.Text = dgrv_dsphieunhap.Rows[i].Cells[4].Value.ToString();
            if (dgrv_dsphieunhap.Rows[i].Cells[5].Value.ToString() == "con hang")
            {
                chk_conhang.Checked = true;
                chk_hethang.Checked = false;
            }
            else
            {

                chk_conhang.Checked = false;
                chk_hethang.Checked = true;
            }
            txt_diachi.Text = dgrv_dsphieunhap.Rows[i].Cells[6].Value.ToString();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Hoadon hoadon = new Hoadon();
             hoadon = _BUShoadon.getlistHD().Where(c => c.Mahoadon == txt_mahd.Text).FirstOrDefault();
            _BUShoadon.DeleteHD(hoadon); 
            MessageBox.Show(" xoa thanh cong", " thong bao");
            _BUShoadon.getlistHD();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var hoadon = _BUShoadon.getlistHD().Where(c => c.Mahoadon == txt_mahd.Text).FirstOrDefault();
            hoadon.Mahoadon = txt_mahd.Text;
            hoadon.Makhach = txt_makh.Text;
            hoadon.Manhanvien = txt_manv.Text;
            hoadon.Ngaydathang = Convert.ToDateTime(txt_ngaylaphd.Text);
            hoadon.Tiendatcoc = Convert.ToDecimal(txt_tiendatcoc.Text);
            if (chk_conhang.Checked == true)
            {
                hoadon.Trangthai = "con hang";
            }
            if (chk_hethang.Checked == true)
            {
                hoadon.Trangthai = "het hang";
            }

            _BUShoadon.UpdateHD(hoadon);
            MessageBox.Show(" sua thanh cong", " thong bao");
            _BUShoadon.getlistHD();

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            _BUShoadon.Save();
            MessageBox.Show("luu thanh cong", "thong bao");
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            loadData();
            MessageBox.Show("bo qua thanh cong", "thong bao");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dong thanh cong", "thong bao");
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
