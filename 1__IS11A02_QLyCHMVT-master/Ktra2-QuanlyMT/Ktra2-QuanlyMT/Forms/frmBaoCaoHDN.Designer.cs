namespace Ktra2_QuanlyMT.Forms
{
    partial class frmBaoCaoHDN
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
            this.cboQuy = new System.Windows.Forms.ComboBox();
            this.txtNguoiBC = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboQuy
            // 
            this.cboQuy.FormattingEnabled = true;
            this.cboQuy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboQuy.Location = new System.Drawing.Point(230, 127);
            this.cboQuy.Margin = new System.Windows.Forms.Padding(2);
            this.cboQuy.Name = "cboQuy";
            this.cboQuy.Size = new System.Drawing.Size(112, 21);
            this.cboQuy.TabIndex = 18;
            // 
            // txtNguoiBC
            // 
            this.txtNguoiBC.Location = new System.Drawing.Point(230, 201);
            this.txtNguoiBC.Margin = new System.Windows.Forms.Padding(2);
            this.txtNguoiBC.Name = "txtNguoiBC";
            this.txtNguoiBC.Size = new System.Drawing.Size(110, 20);
            this.txtNguoiBC.TabIndex = 17;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(230, 162);
            this.txtNam.Margin = new System.Windows.Forms.Padding(2);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(110, 20);
            this.txtNam.TabIndex = 16;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(354, 245);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(56, 19);
            this.btnDong.TabIndex = 15;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(98, 245);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(56, 19);
            this.btnBaoCao.TabIndex = 14;
            this.btnBaoCao.Text = "&Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Người Báo Cáo  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Năm  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quý  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Báo Cáo Nhập Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tháng :";
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThang.Location = new System.Drawing.Point(230, 86);
            this.cboThang.Margin = new System.Windows.Forms.Padding(2);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(112, 21);
            this.cboThang.TabIndex = 20;
            // 
            // frmBaoCaoHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ktra2_QuanlyMT.Properties.Resources.abstract_colorful_flow_shapes_background_23_2148258092;
            this.ClientSize = new System.Drawing.Size(518, 328);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboQuy);
            this.Controls.Add(this.txtNguoiBC);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBaoCaoHDN";
            this.Text = "frmBaoCaoHDN";
            this.Load += new System.EventHandler(this.frmBaoCaoHDN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboQuy;
        private System.Windows.Forms.TextBox txtNguoiBC;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboThang;
    }
}