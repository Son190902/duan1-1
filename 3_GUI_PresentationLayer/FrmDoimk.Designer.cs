
namespace _3_GUI_PresentationLayer
{
    partial class FrmDoimk
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
            this.txt_newpass1 = new System.Windows.Forms.TextBox();
            this.txt_newpass = new System.Windows.Forms.TextBox();
            this.txt_oldpass = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_doimk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_newpass1
            // 
            this.txt_newpass1.Location = new System.Drawing.Point(328, 330);
            this.txt_newpass1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_newpass1.Name = "txt_newpass1";
            this.txt_newpass1.Size = new System.Drawing.Size(182, 27);
            this.txt_newpass1.TabIndex = 10;
            // 
            // txt_newpass
            // 
            this.txt_newpass.Location = new System.Drawing.Point(328, 259);
            this.txt_newpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_newpass.Name = "txt_newpass";
            this.txt_newpass.Size = new System.Drawing.Size(182, 27);
            this.txt_newpass.TabIndex = 11;
            // 
            // txt_oldpass
            // 
            this.txt_oldpass.Location = new System.Drawing.Point(328, 185);
            this.txt_oldpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_oldpass.Name = "txt_oldpass";
            this.txt_oldpass.Size = new System.Drawing.Size(182, 27);
            this.txt_oldpass.TabIndex = 12;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(328, 120);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(182, 27);
            this.txt_Email.TabIndex = 13;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(592, 481);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(126, 31);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "THOÁT";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_doimk
            // 
            this.btn_doimk.Location = new System.Drawing.Point(367, 430);
            this.btn_doimk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_doimk.Name = "btn_doimk";
            this.btn_doimk.Size = new System.Drawing.Size(126, 31);
            this.btn_doimk.TabIndex = 9;
            this.btn_doimk.Text = "ĐỔI MẬT KHẨU";
            this.btn_doimk.UseVisualStyleBackColor = true;
            this.btn_doimk.Click += new System.EventHandler(this.btn_doimk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "NHẬP LẠI MẬT KHẨU MỚI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "MẬT KHẨU MỚI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "MẬT KHẨU CŨ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "EMAIL NHÂN VIÊN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ĐỔI MẬT KHẨU NHÂN VIÊN";
            // 
            // FrmDoimk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 668);
            this.Controls.Add(this.txt_newpass1);
            this.Controls.Add(this.txt_newpass);
            this.Controls.Add(this.txt_oldpass);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_doimk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDoimk";
            this.Text = "FrmDoimk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_newpass1;
        private System.Windows.Forms.TextBox txt_newpass;
        private System.Windows.Forms.TextBox txt_oldpass;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_doimk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}