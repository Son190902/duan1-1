
namespace _3_GUI_PresentationLayer
{
    partial class Frm_Chitiethoadon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label10;
            this.label1 = new System.Windows.Forms.Label();
            this.rbt_khd = new System.Windows.Forms.RadioButton();
            this.rbt_hd = new System.Windows.Forms.RadioButton();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tongtienthanhtoan = new System.Windows.Forms.TextBox();
            this.txt_madv = new System.Windows.Forms.TextBox();
            this.txt_machitietsp = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgrv_cthd = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_machitiethd = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_cthd)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(487, 236);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(81, 20);
            label10.TabIndex = 64;
            label10.Text = "Trạng Thái:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(599, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chi Tiết Hóa Đơn";
            // 
            // rbt_khd
            // 
            this.rbt_khd.AutoSize = true;
            this.rbt_khd.Location = new System.Drawing.Point(628, 251);
            this.rbt_khd.Name = "rbt_khd";
            this.rbt_khd.Size = new System.Drawing.Size(149, 24);
            this.rbt_khd.TabIndex = 66;
            this.rbt_khd.TabStop = true;
            this.rbt_khd.Text = "Không Hoạt động";
            this.rbt_khd.UseVisualStyleBackColor = true;
            // 
            // rbt_hd
            // 
            this.rbt_hd.AutoSize = true;
            this.rbt_hd.Location = new System.Drawing.Point(628, 221);
            this.rbt_hd.Name = "rbt_hd";
            this.rbt_hd.Size = new System.Drawing.Size(102, 24);
            this.rbt_hd.TabIndex = 65;
            this.rbt_hd.TabStop = true;
            this.rbt_hd.Text = "Hoạt động";
            this.rbt_hd.UseVisualStyleBackColor = true;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(628, 129);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(189, 27);
            this.txt_dongia.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(491, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "Đơn giá:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_tongtienthanhtoan
            // 
            this.txt_tongtienthanhtoan.Location = new System.Drawing.Point(1118, 153);
            this.txt_tongtienthanhtoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tongtienthanhtoan.Name = "txt_tongtienthanhtoan";
            this.txt_tongtienthanhtoan.Size = new System.Drawing.Size(185, 27);
            this.txt_tongtienthanhtoan.TabIndex = 58;
            // 
            // txt_madv
            // 
            this.txt_madv.Location = new System.Drawing.Point(628, 194);
            this.txt_madv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_madv.Name = "txt_madv";
            this.txt_madv.Size = new System.Drawing.Size(187, 27);
            this.txt_madv.TabIndex = 57;
            // 
            // txt_machitietsp
            // 
            this.txt_machitietsp.Location = new System.Drawing.Point(204, 194);
            this.txt_machitietsp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_machitietsp.Name = "txt_machitietsp";
            this.txt_machitietsp.Size = new System.Drawing.Size(187, 27);
            this.txt_machitietsp.TabIndex = 56;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(630, 69);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(187, 27);
            this.txt_soluong.TabIndex = 55;
            // 
            // txt_mahd
            // 
            this.txt_mahd.Location = new System.Drawing.Point(204, 129);
            this.txt_mahd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(187, 27);
            this.txt_mahd.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Mã dịch vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Mã chi tiết sp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Mã Hóa Đơn:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(916, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 20);
            this.label11.TabIndex = 59;
            this.label11.Text = "Ngày giao hàng: ";
            this.label11.Click += new System.EventHandler(this.label9_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(916, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 20);
            this.label12.TabIndex = 59;
            this.label12.Text = "Tổng tiền thanh toán: ";
            this.label12.Click += new System.EventHandler(this.label9_Click);
            // 
            // dgrv_cthd
            // 
            this.dgrv_cthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv_cthd.Location = new System.Drawing.Point(79, 312);
            this.dgrv_cthd.Name = "dgrv_cthd";
            this.dgrv_cthd.RowHeadersWidth = 51;
            this.dgrv_cthd.RowTemplate.Height = 29;
            this.dgrv_cthd.Size = new System.Drawing.Size(1329, 298);
            this.dgrv_cthd.TabIndex = 67;
            this.dgrv_cthd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrv_cthd_CellClick);
            this.dgrv_cthd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrv_cthd_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThem.Location = new System.Drawing.Point(254, 648);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 45);
            this.btnThem.TabIndex = 68;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDong.Location = new System.Drawing.Point(1065, 648);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(109, 45);
            this.btnDong.TabIndex = 73;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click_1);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBoQua.Location = new System.Drawing.Point(905, 648);
            this.btnBoQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(111, 45);
            this.btnBoQua.TabIndex = 72;
            this.btnBoQua.Text = "&Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.Location = new System.Drawing.Point(411, 648);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 45);
            this.btnXoa.TabIndex = 69;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSua.Location = new System.Drawing.Point(563, 648);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(121, 45);
            this.btnSua.TabIndex = 70;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLuu.Location = new System.Drawing.Point(732, 648);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(123, 45);
            this.btnLuu.TabIndex = 71;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Mã chi tiết hđ:";
            // 
            // txt_machitiethd
            // 
            this.txt_machitiethd.Location = new System.Drawing.Point(204, 69);
            this.txt_machitiethd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_machitiethd.Name = "txt_machitiethd";
            this.txt_machitiethd.Size = new System.Drawing.Size(187, 27);
            this.txt_machitiethd.TabIndex = 54;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1118, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 27);
            this.dateTimePicker1.TabIndex = 74;
            // 
            // Frm_Chitiethoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 724);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgrv_cthd);
            this.Controls.Add(this.rbt_khd);
            this.Controls.Add(this.rbt_hd);
            this.Controls.Add(label10);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_tongtienthanhtoan);
            this.Controls.Add(this.txt_madv);
            this.Controls.Add(this.txt_machitietsp);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.txt_machitiethd);
            this.Controls.Add(this.txt_mahd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Chitiethoadon";
            this.Text = "Frm_Chitiethoadon";
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_cthd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbt_khd;
        private System.Windows.Forms.RadioButton rbt_hd;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tongtienthanhtoan;
        private System.Windows.Forms.TextBox txt_madv;
        private System.Windows.Forms.TextBox txt_machitietsp;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgrv_cthd;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_machitiethd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}