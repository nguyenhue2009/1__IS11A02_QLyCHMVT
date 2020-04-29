namespace Ktra2_QuanlyMT.Forms
{
    partial class frmTKSP
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
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntTimlai = new System.Windows.Forms.Button();
            this.bntTimKiem = new System.Windows.Forms.Button();
            this.txtTenHangSanXuat = new System.Windows.Forms.TextBox();
            this.txtTenLoaiMay = new System.Windows.Forms.TextBox();
            this.txtMaMayTinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bntThoat
            // 
            this.bntThoat.Location = new System.Drawing.Point(695, 11);
            this.bntThoat.Margin = new System.Windows.Forms.Padding(2);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(94, 43);
            this.bntThoat.TabIndex = 19;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // bntTimlai
            // 
            this.bntTimlai.Location = new System.Drawing.Point(209, 330);
            this.bntTimlai.Margin = new System.Windows.Forms.Padding(2);
            this.bntTimlai.Name = "bntTimlai";
            this.bntTimlai.Size = new System.Drawing.Size(94, 43);
            this.bntTimlai.TabIndex = 18;
            this.bntTimlai.Text = "Tìm lại";
            this.bntTimlai.UseVisualStyleBackColor = true;
            this.bntTimlai.Click += new System.EventHandler(this.bntTimlai_Click);
            // 
            // bntTimKiem
            // 
            this.bntTimKiem.Location = new System.Drawing.Point(59, 330);
            this.bntTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.bntTimKiem.Name = "bntTimKiem";
            this.bntTimKiem.Size = new System.Drawing.Size(94, 43);
            this.bntTimKiem.TabIndex = 17;
            this.bntTimKiem.Text = "Tìm kiếm";
            this.bntTimKiem.UseVisualStyleBackColor = true;
            this.bntTimKiem.Click += new System.EventHandler(this.bntTimKiem_Click);
            // 
            // txtTenHangSanXuat
            // 
            this.txtTenHangSanXuat.Location = new System.Drawing.Point(204, 168);
            this.txtTenHangSanXuat.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenHangSanXuat.Name = "txtTenHangSanXuat";
            this.txtTenHangSanXuat.Size = new System.Drawing.Size(114, 20);
            this.txtTenHangSanXuat.TabIndex = 15;
            // 
            // txtTenLoaiMay
            // 
            this.txtTenLoaiMay.Location = new System.Drawing.Point(204, 245);
            this.txtTenLoaiMay.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenLoaiMay.Name = "txtTenLoaiMay";
            this.txtTenLoaiMay.Size = new System.Drawing.Size(114, 20);
            this.txtTenLoaiMay.TabIndex = 14;
            // 
            // txtMaMayTinh
            // 
            this.txtMaMayTinh.Location = new System.Drawing.Point(204, 99);
            this.txtMaMayTinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaMayTinh.Name = "txtMaMayTinh";
            this.txtMaMayTinh.Size = new System.Drawing.Size(114, 20);
            this.txtMaMayTinh.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(69, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên hãng sản xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(69, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên loại máy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(69, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã máy tính";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(360, 71);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(400, 302);
            this.DataGridView.TabIndex = 20;
            this.DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.label4.Location = new System.Drawing.Point(40, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 31);
            this.label4.TabIndex = 68;
            this.label4.Text = "TÌM KIẾM MÁY VI TÍNH";
            // 
            // frmTKSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ktra2_QuanlyMT.Properties.Resources.mau_background_don_gian_03_1024x819;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.bntTimlai);
            this.Controls.Add(this.bntTimKiem);
            this.Controls.Add(this.txtTenHangSanXuat);
            this.Controls.Add(this.txtTenLoaiMay);
            this.Controls.Add(this.txtMaMayTinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTKSP";
            this.Text = "frmTKSP";
            this.Load += new System.EventHandler(this.frmTKSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button bntTimlai;
        private System.Windows.Forms.Button bntTimKiem;
        private System.Windows.Forms.TextBox txtTenHangSanXuat;
        private System.Windows.Forms.TextBox txtTenLoaiMay;
        private System.Windows.Forms.TextBox txtMaMayTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label label4;
    }
}