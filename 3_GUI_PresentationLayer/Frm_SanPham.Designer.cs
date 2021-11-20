
namespace _3_GUI_PresentationLayer
{
    partial class Frm_SanPham
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgrv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.txt_msp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_dánhach = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.txt_mausac = new System.Windows.Forms.TextBox();
            this.cbx_loaisp = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_dvtinh = new System.Windows.Forms.TextBox();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_khonghoatdong = new System.Windows.Forms.CheckBox();
            this.cbx_hoatdong = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrv
            // 
            this.dgrv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv.Location = new System.Drawing.Point(90, 261);
            this.dgrv.Name = "dgrv";
            this.dgrv.RowHeadersWidth = 51;
            this.dgrv.RowTemplate.Height = 25;
            this.dgrv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgrv.Size = new System.Drawing.Size(1306, 294);
            this.dgrv.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(769, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "TÌM KIẾM";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(551, 12);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(188, 23);
            this.txt_timkiem.TabIndex = 24;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(371, 187);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(163, 23);
            this.txt_dongia.TabIndex = 22;
            // 
            // txt_msp
            // 
            this.txt_msp.Location = new System.Drawing.Point(371, 91);
            this.txt_msp.Name = "txt_msp";
            this.txt_msp.Size = new System.Drawing.Size(163, 23);
            this.txt_msp.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, -20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "HÌNH ẢNH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "ĐƠN GIÁ BÁN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "SỐ LƯỢNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "TÊN SẢN PHẨM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "MÃ SẢN PHẨM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, -26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "SẢN PHẨM";
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(551, 53);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 34;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(412, 53);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 35;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(276, 53);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 36;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(1074, 53);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(75, 23);
            this.btn_dong.TabIndex = 37;
            this.btn_dong.Text = "ĐÓNG";
            this.btn_dong.UseVisualStyleBackColor = true;
            // 
            // btn_boqua
            // 
            this.btn_boqua.Location = new System.Drawing.Point(958, 53);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(75, 23);
            this.btn_boqua.TabIndex = 38;
            this.btn_boqua.Text = "BỎ QUA";
            this.btn_boqua.UseVisualStyleBackColor = true;
            // 
            // btn_dánhach
            // 
            this.btn_dánhach.Location = new System.Drawing.Point(820, 53);
            this.btn_dánhach.Name = "btn_dánhach";
            this.btn_dánhach.Size = new System.Drawing.Size(86, 23);
            this.btn_dánhach.TabIndex = 39;
            this.btn_dánhach.Text = "DANH SÁCH";
            this.btn_dánhach.UseVisualStyleBackColor = true;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(688, 53);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 40;
            this.btn_luu.Text = "LƯU";
            this.btn_luu.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(681, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Màu Sắc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(678, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "LOẠI SẢN PHẨM";
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(371, 123);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(163, 23);
            this.txt_tensp.TabIndex = 21;
            this.txt_tensp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_mausac
            // 
            this.txt_mausac.Location = new System.Drawing.Point(742, 118);
            this.txt_mausac.Name = "txt_mausac";
            this.txt_mausac.Size = new System.Drawing.Size(202, 23);
            this.txt_mausac.TabIndex = 25;
            this.txt_mausac.TextChanged += new System.EventHandler(this.txt_mausac_TextChanged);
            // 
            // cbx_loaisp
            // 
            this.cbx_loaisp.FormattingEnabled = true;
            this.cbx_loaisp.Location = new System.Drawing.Point(781, 83);
            this.cbx_loaisp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_loaisp.Name = "cbx_loaisp";
            this.cbx_loaisp.Size = new System.Drawing.Size(163, 23);
            this.cbx_loaisp.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "ĐƠN VỊ TÍNH";
            // 
            // txt_dvtinh
            // 
            this.txt_dvtinh.Location = new System.Drawing.Point(371, 221);
            this.txt_dvtinh.Name = "txt_dvtinh";
            this.txt_dvtinh.Size = new System.Drawing.Size(163, 23);
            this.txt_dvtinh.TabIndex = 25;
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(371, 155);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(163, 23);
            this.txt_sl.TabIndex = 21;
            this.txt_sl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(546, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 28);
            this.label11.TabIndex = 43;
            this.label11.Text = "Quản Lý Sản Phẩm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(679, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 15);
            this.label12.TabIndex = 44;
            this.label12.Text = "Chất Liệu";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(742, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 23);
            this.textBox1.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(681, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 15);
            this.label13.TabIndex = 46;
            this.label13.Text = "Hình Ảnh";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1119, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 194);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(744, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 23);
            this.textBox2.TabIndex = 48;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1038, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 49;
            this.button2.Text = "Mở Ảnh:";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_timkiem);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Controls.Add(this.btn_luu);
            this.panel1.Controls.Add(this.btn_dánhach);
            this.panel1.Controls.Add(this.btn_boqua);
            this.panel1.Controls.Add(this.btn_dong);
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 561);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 100);
            this.panel1.TabIndex = 50;
            // 
            // cbx_khonghoatdong
            // 
            this.cbx_khonghoatdong.AutoSize = true;
            this.cbx_khonghoatdong.Location = new System.Drawing.Point(854, 225);
            this.cbx_khonghoatdong.Name = "cbx_khonghoatdong";
            this.cbx_khonghoatdong.Size = new System.Drawing.Size(77, 19);
            this.cbx_khonghoatdong.TabIndex = 52;
            this.cbx_khonghoatdong.Text = "Hết Hàng";
            this.cbx_khonghoatdong.UseVisualStyleBackColor = true;
            // 
            // cbx_hoatdong
            // 
            this.cbx_hoatdong.AutoSize = true;
            this.cbx_hoatdong.Location = new System.Drawing.Point(768, 225);
            this.cbx_hoatdong.Name = "cbx_hoatdong";
            this.cbx_hoatdong.Size = new System.Drawing.Size(80, 19);
            this.cbx_hoatdong.TabIndex = 53;
            this.cbx_hoatdong.Text = "Còn Hàng";
            this.cbx_hoatdong.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(688, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 15);
            this.label10.TabIndex = 51;
            this.label10.Text = "TRẠNG THÁI";
            // 
            // Frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 661);
            this.Controls.Add(this.cbx_khonghoatdong);
            this.Controls.Add(this.cbx_hoatdong);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbx_loaisp);
            this.Controls.Add(this.dgrv);
            this.Controls.Add(this.txt_dvtinh);
            this.Controls.Add(this.txt_mausac);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.txt_sl);
            this.Controls.Add(this.txt_tensp);
            this.Controls.Add(this.txt_msp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_SanPham";
            this.Text = "Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.Frm_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.TextBox txt_msp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_dánhach;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.TextBox txt_mausac;
        private System.Windows.Forms.ComboBox cbx_loaisp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_dvtinh;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbx_khonghoatdong;
        private System.Windows.Forms.CheckBox cbx_hoatdong;
        private System.Windows.Forms.Label label10;
    }
}

