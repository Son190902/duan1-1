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
    public partial class Frm_Chitiethoadon : Form
    {
        private IBUSchitiethoadon _BUSchitiethoadon;
        
        public Frm_Chitiethoadon()
        {
            InitializeComponent();
            _BUSchitiethoadon = new BUSchitiethoadon();
            loadData();
        }

        public void loadData()
        {
            dgrv_cthd.ColumnCount = 9;
            dgrv_cthd.Columns[0].Name = "ma CTHD";
            dgrv_cthd.Columns[1].Name = "ma hoa don";
            dgrv_cthd.Columns[2].Name = "ma ct san pham";
            dgrv_cthd.Columns[3].Name = "ma dv ";
            dgrv_cthd.Columns[4].Name = "so luong";
            dgrv_cthd.Columns[5].Name = "don gia";
            dgrv_cthd.Columns[6].Name = "ngay giao hang";
            dgrv_cthd.Columns[7].Name = "tong tien thanh toan";
            dgrv_cthd.Columns[8].Name = "trang thai";
            dgrv_cthd.Rows.Clear();
            foreach (var x in _BUSchitiethoadon.getlistCTHD())
            {
                dgrv_cthd.Rows.Add(x.MaCtdh, x.Mahoadon, x.Mactsanpham, x.Madichvu, x.Soluong, x.Dongia, x.Ngaygiaohang,
                    x.Tongtienthanhtoan, x.Trangthai);
            }
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Chitiethoadon chitiethoadon = new Chitiethoadon();
            chitiethoadon.MaCtdh = txt_machitiethd.Text;
            chitiethoadon.Mahoadon = txt_mahd.Text;
            chitiethoadon.Mactsanpham = txt_machitietsp.Text;
            chitiethoadon.Madichvu = txt_madv.Text;
            chitiethoadon.Soluong = Convert.ToInt32(txt_soluong.Text);
            chitiethoadon.Dongia = Convert.ToDecimal(txt_dongia.Text);
            chitiethoadon.Ngaygiaohang = Convert.ToDateTime(txt_ngaygiaohang.Text);
            chitiethoadon.Tongtienthanhtoan =Convert.ToDecimal(txt_tongtienthanhtoan.Text);
            if (chitiethoadon.Trangthai == " hoat dong")
            {
                cbx_hd.Checked = true;
            }

            if (chitiethoadon.Trangthai == " khong hoat dong")
            {
                cbx_khd.Checked = true;
            }

            _BUSchitiethoadon.AddCTHD(chitiethoadon, txt_machitiethd.Text, txt_mahd.Text, txt_machitietsp.Text,
                txt_madv.Text, txt_soluong.Text, txt_dongia.Text, txt_ngaygiaohang.Text, txt_tongtienthanhtoan.Text,
                cbx_hd.Checked.ToString());
            MessageBox.Show("them thanh cong", "thong bao");
            _BUSchitiethoadon.getlistCTHD();

            loadData();
             
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var chitiethoadon = _BUSchitiethoadon.getlistCTHD().Where(c => c.MaCtdh == txt_machitiethd.Text)
                .FirstOrDefault();
            _BUSchitiethoadon.DeleteCTHD(chitiethoadon);
            MessageBox.Show("xoa thanh cong", "thong bao");
            _BUSchitiethoadon.getlistCTHD();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Chitiethoadon chitiethoadon = new Chitiethoadon();
            chitiethoadon.MaCtdh = txt_machitiethd.Text;
            chitiethoadon.Mahoadon = txt_mahd.Text;
            chitiethoadon.Mactsanpham = txt_machitietsp.Text;
            chitiethoadon.Madichvu = txt_madv.Text;
            chitiethoadon.Soluong = Convert.ToInt32(txt_soluong.Text);
            chitiethoadon.Dongia = Convert.ToDecimal(txt_dongia.Text);
            chitiethoadon.Ngaygiaohang = Convert.ToDateTime(txt_ngaygiaohang.Text);
            chitiethoadon.Tongtienthanhtoan = Convert.ToDecimal(txt_tongtienthanhtoan.Text);
            if (chitiethoadon.Trangthai == " hoat dong")
            {
                cbx_hd.Checked = true;
            }

            if (chitiethoadon.Trangthai == " khong hoat dong")
            {
                cbx_khd.Checked = true;
            }

            _BUSchitiethoadon.UpdateCTHD(chitiethoadon);
            MessageBox.Show("sua thanh cong", "thong bao");
            _BUSchitiethoadon.getlistCTHD();

            loadData();
        }

        private void dgrv_cthd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if( i == _BUSchitiethoadon.getlistCTHD().Count) return;
            txt_machitiethd.Text = dgrv_cthd.Rows[i].Cells[0].Value.ToString();
            txt_mahd.Text = dgrv_cthd.Rows[i].Cells[1].Value.ToString();
            txt_machitietsp.Text = dgrv_cthd.Rows[i].Cells[2].Value.ToString();
            txt_madv.Text = dgrv_cthd.Rows[i].Cells[3].Value.ToString();
            txt_soluong.Text = dgrv_cthd.Rows[i].Cells[4].Value.ToString();
            txt_dongia.Text = dgrv_cthd.Rows[i].Cells[5].Value.ToString();
            txt_ngaygiaohang.Text = dgrv_cthd.Rows[i].Cells[6].Value.ToString();
            txt_tongtienthanhtoan.Text = dgrv_cthd.Rows[i].Cells[7].Value.ToString();
            if (dgrv_cthd.Rows[i].Cells[5].Value.ToString() == "con hang")
            {
                cbx_hd.Checked = true;
                cbx_khd.Checked = false;
            }
            else
            {

                cbx_hd.Checked = false;
                cbx_khd.Checked = true;
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            _BUSchitiethoadon.Save();
            MessageBox.Show("luu thanh cong", "thong bao");
        }
        
        private void btnBoQua_Click_1(object sender, EventArgs e)
        {
            loadData();
            MessageBox.Show("bo qua thanh cong", "thong bao");
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("dong thanh cong", "thong bao");
        }
    }
}
