
namespace _3_GUI_PresentationLayer
{
    partial class FrmHoaDon
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
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label10;
            this.txtTimKiem = new System.Windows.Forms.GroupBox();
            this.chk_hethang = new System.Windows.Forms.RadioButton();
            this.chk_conhang = new System.Windows.Forms.RadioButton();
            this.txt_tiendatcoc = new System.Windows.Forms.TextBox();
            this.dttimepicker_ngaynhanhang = new System.Windows.Forms.DateTimePicker();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrv_dsphieunhap = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            label8 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            this.txtTimKiem.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_dsphieunhap)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(550, 28);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(126, 28);
            label8.TabIndex = 16;
            label8.Text = "Tiền Đặt Cọc:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(142, 135);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(105, 28);
            label10.TabIndex = 18;
            label10.Text = "Trạng Thái:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Controls.Add(this.chk_hethang);
            this.txtTimKiem.Controls.Add(this.chk_conhang);
            this.txtTimKiem.Controls.Add(label10);
            this.txtTimKiem.Controls.Add(this.txt_tiendatcoc);
            this.txtTimKiem.Controls.Add(label8);
            this.txtTimKiem.Controls.Add(this.dttimepicker_ngaynhanhang);
            this.txtTimKiem.Controls.Add(this.txt_makh);
            this.txtTimKiem.Controls.Add(this.label9);
            this.txtTimKiem.Controls.Add(this.txt_manv);
            this.txtTimKiem.Controls.Add(this.txt_mahd);
            this.txtTimKiem.Controls.Add(this.label5);
            this.txtTimKiem.Controls.Add(this.label3);
            this.txtTimKiem.Controls.Add(this.label2);
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.Location = new System.Drawing.Point(14, 88);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Size = new System.Drawing.Size(1670, 184);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TabStop = false;
            this.txtTimKiem.Text = "Thông Tin Chung";
            // 
            // chk_hethang
            // 
            this.chk_hethang.AutoSize = true;
            this.chk_hethang.Location = new System.Drawing.Point(424, 145);
            this.chk_hethang.Name = "chk_hethang";
            this.chk_hethang.Size = new System.Drawing.Size(113, 32);
            this.chk_hethang.TabIndex = 47;
            this.chk_hethang.TabStop = true;
            this.chk_hethang.Text = "Hết hàng";
            this.chk_hethang.UseVisualStyleBackColor = true;
            // 
            // chk_conhang
            // 
            this.chk_conhang.AutoSize = true;
            this.chk_conhang.Location = new System.Drawing.Point(301, 145);
            this.chk_conhang.Name = "chk_conhang";
            this.chk_conhang.Size = new System.Drawing.Size(117, 32);
            this.chk_conhang.TabIndex = 46;
            this.chk_conhang.TabStop = true;
            this.chk_conhang.Text = "Còn hàng";
            this.chk_conhang.UseVisualStyleBackColor = true;
            // 
            // txt_tiendatcoc
            // 
            this.txt_tiendatcoc.Location = new System.Drawing.Point(745, 23);
            this.txt_tiendatcoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tiendatcoc.Name = "txt_tiendatcoc";
            this.txt_tiendatcoc.Size = new System.Drawing.Size(189, 34);
            this.txt_tiendatcoc.TabIndex = 17;
            // 
            // dttimepicker_ngaynhanhang
            // 
            this.dttimepicker_ngaynhanhang.Location = new System.Drawing.Point(1252, 28);
            this.dttimepicker_ngaynhanhang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dttimepicker_ngaynhanhang.Name = "dttimepicker_ngaynhanhang";
            this.dttimepicker_ngaynhanhang.Size = new System.Drawing.Size(285, 34);
            this.dttimepicker_ngaynhanhang.TabIndex = 15;
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(745, 85);
            this.txt_makh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(189, 34);
            this.txt_makh.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(550, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 28);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mã Khách Hàng:";
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(301, 82);
            this.txt_manv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(187, 34);
            this.txt_manv.TabIndex = 9;
            // 
            // txt_mahd
            // 
            this.txt_mahd.Location = new System.Drawing.Point(301, 23);
            this.txt_mahd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(187, 34);
            this.txt_mahd.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1067, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày Đặt Hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Nhân Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Hóa Đơn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(818, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hóa Đơn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrv_dsphieunhap);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(14, 280);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1670, 447);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Phiếu Nhập";
            // 
            // dgrv_dsphieunhap
            // 
            this.dgrv_dsphieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv_dsphieunhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrv_dsphieunhap.Location = new System.Drawing.Point(3, 31);
            this.dgrv_dsphieunhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgrv_dsphieunhap.Name = "dgrv_dsphieunhap";
            this.dgrv_dsphieunhap.RowHeadersWidth = 51;
            this.dgrv_dsphieunhap.RowTemplate.Height = 25;
            this.dgrv_dsphieunhap.Size = new System.Drawing.Size(1664, 412);
            this.dgrv_dsphieunhap.TabIndex = 0;
            this.dgrv_dsphieunhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrv_dsphieunhap_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThem.Location = new System.Drawing.Point(407, 45);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 45);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.Location = new System.Drawing.Point(537, 45);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 45);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLuu.Location = new System.Drawing.Point(849, 45);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(141, 45);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSua.Location = new System.Drawing.Point(689, 45);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(121, 45);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBoQua.Location = new System.Drawing.Point(1031, 45);
            this.btnBoQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(111, 45);
            this.btnBoQua.TabIndex = 8;
            this.btnBoQua.Text = "&Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDong.Location = new System.Drawing.Point(1191, 45);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(109, 45);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.btnBoQua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 735);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1691, 128);
            this.panel2.TabIndex = 10;
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1691, 863);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiem);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmHoaDon";
            this.Text = "FrmHoaDon";
            this.Load += new System.EventHandler(this.FrmHoaDon_Load);
            this.txtTimKiem.ResumeLayout(false);
            this.txtTimKiem.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_dsphieunhap)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgrv_dsphieunhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.TextBox txt_tiendatcoc;
        private System.Windows.Forms.DateTimePicker dttimepicker_ngaynhanhang;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton chk_hethang;
        private System.Windows.Forms.RadioButton chk_conhang;
        private System.Windows.Forms.TextBox txt_manv;
    }
}