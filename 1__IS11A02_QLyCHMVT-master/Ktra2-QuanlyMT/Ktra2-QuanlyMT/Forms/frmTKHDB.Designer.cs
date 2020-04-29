namespace Ktra2_QuanlyMT.Forms
{
    partial class frmTKHDB
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
            this.button1 = new System.Windows.Forms.Button();
            this.bntTimkiem = new System.Windows.Forms.Button();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaMayViTinh = new System.Windows.Forms.TextBox();
            this.txtMaHoaDonBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntThoat
            // 
            this.bntThoat.Location = new System.Drawing.Point(520, 205);
            this.bntThoat.Margin = new System.Windows.Forms.Padding(2);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(56, 19);
            this.bntThoat.TabIndex = 23;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 205);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 22;
            this.button1.Text = "Tìm lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntTimkiem
            // 
            this.bntTimkiem.Location = new System.Drawing.Point(199, 205);
            this.bntTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.bntTimkiem.Name = "bntTimkiem";
            this.bntTimkiem.Size = new System.Drawing.Size(56, 19);
            this.bntTimkiem.TabIndex = 21;
            this.bntTimkiem.Text = "Tìm kiếm";
            this.bntTimkiem.UseVisualStyleBackColor = true;
            this.bntTimkiem.Click += new System.EventHandler(this.bntTimkiem_Click);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(493, 132);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(76, 20);
            this.txtMaNhanVien.TabIndex = 19;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(493, 82);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(76, 20);
            this.txtMaKhachHang.TabIndex = 18;
            // 
            // txtMaMayViTinh
            // 
            this.txtMaMayViTinh.Location = new System.Drawing.Point(250, 134);
            this.txtMaMayViTinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaMayViTinh.Name = "txtMaMayViTinh";
            this.txtMaMayViTinh.Size = new System.Drawing.Size(76, 20);
            this.txtMaMayViTinh.TabIndex = 17;
            // 
            // txtMaHoaDonBan
            // 
            this.txtMaHoaDonBan.Location = new System.Drawing.Point(250, 85);
            this.txtMaHoaDonBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHoaDonBan.Name = "txtMaHoaDonBan";
            this.txtMaHoaDonBan.Size = new System.Drawing.Size(76, 20);
            this.txtMaHoaDonBan.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã máy vi tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã HĐB";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(158, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 170);
            this.dataGridView1.TabIndex = 24;
            // 
            // frmTKHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ktra2_QuanlyMT.Properties.Resources.mau_background_don_gian_03_1024x819;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bntTimkiem);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.txtMaMayViTinh);
            this.Controls.Add(this.txtMaHoaDonBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTKHDB";
            this.Text = "frmTKHDB";
            this.Load += new System.EventHandler(this.frmTKHDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bntTimkiem;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.TextBox txtMaMayViTinh;
        private System.Windows.Forms.TextBox txtMaHoaDonBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}