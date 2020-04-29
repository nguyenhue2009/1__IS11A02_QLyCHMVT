using System;

namespace Ktra2_QuanlyMT.Forms
{
    partial class frmBaoCaoHDB
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtNguoiBC = new System.Windows.Forms.TextBox();
            this.cboQuy = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo Cáo Bán Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quý  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Người Báo Cáo  :";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(77, 228);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(66, 19);
            this.btnBaoCao.TabIndex = 4;
            this.btnBaoCao.Text = "&Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click_1);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(321, 228);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(56, 19);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(209, 116);
            this.txtNam.Margin = new System.Windows.Forms.Padding(2);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(110, 20);
            this.txtNam.TabIndex = 7;
            // 
            // txtNguoiBC
            // 
            this.txtNguoiBC.Location = new System.Drawing.Point(209, 155);
            this.txtNguoiBC.Margin = new System.Windows.Forms.Padding(2);
            this.txtNguoiBC.Name = "txtNguoiBC";
            this.txtNguoiBC.Size = new System.Drawing.Size(110, 20);
            this.txtNguoiBC.TabIndex = 8;
            // 
            // cboQuy
            // 
            this.cboQuy.FormattingEnabled = true;
            this.cboQuy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboQuy.Location = new System.Drawing.Point(209, 81);
            this.cboQuy.Margin = new System.Windows.Forms.Padding(2);
            this.cboQuy.Name = "cboQuy";
            this.cboQuy.Size = new System.Drawing.Size(112, 21);
            this.cboQuy.TabIndex = 9;
            // 
            // frmBaoCaoHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ktra2_QuanlyMT.Properties.Resources.abstract_colorful_flow_shapes_background_23_2148258092;
            this.ClientSize = new System.Drawing.Size(466, 283);
            this.Controls.Add(this.cboQuy);
            this.Controls.Add(this.txtNguoiBC);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBaoCaoHDB";
            this.Text = "Báo Cáo Hoạt Động Nhập";
            this.Load += new System.EventHandler(this.frmBaoCaoHDB_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtNguoiBC;
        private System.Windows.Forms.ComboBox cboQuy;
    }
}