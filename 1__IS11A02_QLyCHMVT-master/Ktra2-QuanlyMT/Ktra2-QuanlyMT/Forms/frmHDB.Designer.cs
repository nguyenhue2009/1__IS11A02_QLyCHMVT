namespace Ktra2_QuanlyMT.Forms
{
    partial class frmHDB
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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbChitiet = new System.Windows.Forms.GroupBox();
            this.txtBaohanh = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTong_tien = new System.Windows.Forms.TextBox();
            this.cboMa_mayVT = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDon_gia = new System.Windows.Forms.TextBox();
            this.labels = new System.Windows.Forms.Label();
            this.txtSo_luong = new System.Windows.Forms.TextBox();
            this.labelTen = new System.Windows.Forms.Label();
            this.txtTen_mayVT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayban = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa_HDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView_HDB = new System.Windows.Forms.DataGridView();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grbChitiet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HDB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(404, 448);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(88, 34);
            this.btnDong.TabIndex = 35;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(255, 448);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 34);
            this.btnLuu.TabIndex = 33;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(534, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Thành tiền";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(135, 448);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 34);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbChitiet
            // 
            this.grbChitiet.Controls.Add(this.txtBaohanh);
            this.grbChitiet.Controls.Add(this.label11);
            this.grbChitiet.Controls.Add(this.txtTong_tien);
            this.grbChitiet.Controls.Add(this.cboMa_mayVT);
            this.grbChitiet.Controls.Add(this.label6);
            this.grbChitiet.Controls.Add(this.txtDon_gia);
            this.grbChitiet.Controls.Add(this.labels);
            this.grbChitiet.Controls.Add(this.txtSo_luong);
            this.grbChitiet.Controls.Add(this.label7);
            this.grbChitiet.Controls.Add(this.labelTen);
            this.grbChitiet.Controls.Add(this.txtTen_mayVT);
            this.grbChitiet.Controls.Add(this.label9);
            this.grbChitiet.Location = new System.Drawing.Point(72, 177);
            this.grbChitiet.Name = "grbChitiet";
            this.grbChitiet.Size = new System.Drawing.Size(770, 94);
            this.grbChitiet.TabIndex = 28;
            this.grbChitiet.TabStop = false;
            this.grbChitiet.Text = "Thông tin chi tiết hàng";
            this.grbChitiet.Enter += new System.EventHandler(this.grbChitiet_Enter);
            // 
            // txtBaohanh
            // 
            this.txtBaohanh.Location = new System.Drawing.Point(383, 62);
            this.txtBaohanh.Name = "txtBaohanh";
            this.txtBaohanh.Size = new System.Drawing.Size(100, 20);
            this.txtBaohanh.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(294, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 41;
            this.label11.Text = "Thời Hạn BH";
            // 
            // txtTong_tien
            // 
            this.txtTong_tien.Location = new System.Drawing.Point(618, 64);
            this.txtTong_tien.Name = "txtTong_tien";
            this.txtTong_tien.Size = new System.Drawing.Size(124, 20);
            this.txtTong_tien.TabIndex = 40;
            // 
            // cboMa_mayVT
            // 
            this.cboMa_mayVT.FormattingEnabled = true;
            this.cboMa_mayVT.Location = new System.Drawing.Point(126, 27);
            this.cboMa_mayVT.Name = "cboMa_mayVT";
            this.cboMa_mayVT.Size = new System.Drawing.Size(100, 21);
            this.cboMa_mayVT.TabIndex = 22;
            this.cboMa_mayVT.DropDown += new System.EventHandler(this.cboMa_mayVT_DropDown);
            this.cboMa_mayVT.TextChanged += new System.EventHandler(this.cboMa_mayVT_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(534, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Đơn giá";
            // 
            // txtDon_gia
            // 
            this.txtDon_gia.Location = new System.Drawing.Point(618, 27);
            this.txtDon_gia.Name = "txtDon_gia";
            this.txtDon_gia.Size = new System.Drawing.Size(124, 20);
            this.txtDon_gia.TabIndex = 19;
            // 
            // labels
            // 
            this.labels.AutoSize = true;
            this.labels.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labels.Location = new System.Drawing.Point(294, 27);
            this.labels.Name = "labels";
            this.labels.Size = new System.Drawing.Size(63, 16);
            this.labels.TabIndex = 18;
            this.labels.Text = "Số lượng";
            // 
            // txtSo_luong
            // 
            this.txtSo_luong.Location = new System.Drawing.Point(383, 27);
            this.txtSo_luong.Name = "txtSo_luong";
            this.txtSo_luong.Size = new System.Drawing.Size(100, 20);
            this.txtSo_luong.TabIndex = 17;
            this.txtSo_luong.TextChanged += new System.EventHandler(this.txtSo_luong_TextChanged);
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTen.Location = new System.Drawing.Point(34, 64);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(78, 16);
            this.labelTen.TabIndex = 16;
            this.labelTen.Text = "Tên máy VT";
            // 
            // txtTen_mayVT
            // 
            this.txtTen_mayVT.Location = new System.Drawing.Point(126, 62);
            this.txtTen_mayVT.Name = "txtTen_mayVT";
            this.txtTen_mayVT.Size = new System.Drawing.Size(100, 20);
            this.txtTen_mayVT.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Mã Máy VT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMaKH);
            this.groupBox1.Controls.Add(this.cboMaNV);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpNgayban);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMa_HDB);
            this.groupBox1.Location = new System.Drawing.Point(72, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 94);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(355, 61);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(121, 21);
            this.cboMaKH.TabIndex = 26;
            this.cboMaKH.DropDown += new System.EventHandler(this.cboMaKH_DropDown);
            this.cboMaKH.SelectedIndexChanged += new System.EventHandler(this.cboMaKH_SelectedIndexChanged);
            this.cboMaKH.TextChanged += new System.EventHandler(this.cboMaKH_TextChanged);
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(355, 25);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(121, 21);
            this.cboMaNV.TabIndex = 25;
            this.cboMaNV.DropDown += new System.EventHandler(this.cboMaNV_DropDown);
            this.cboMaNV.TextUpdate += new System.EventHandler(this.cboMaNV_TextUpdate);
            this.cboMaNV.TextChanged += new System.EventHandler(this.cboMaNV_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(534, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tên Khách hàng ";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(646, 62);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(100, 20);
            this.txtTenKH.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(534, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Tên Nhân viên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(637, 25);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(100, 20);
            this.txtTenNV.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mã KH";
            // 
            // dtpNgayban
            // 
            this.dtpNgayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayban.Location = new System.Drawing.Point(126, 59);
            this.dtpNgayban.Name = "dtpNgayban";
            this.dtpNgayban.Size = new System.Drawing.Size(100, 20);
            this.dtpNgayban.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã Nv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã HDB";
            // 
            // txtMa_HDB
            // 
            this.txtMa_HDB.Location = new System.Drawing.Point(126, 26);
            this.txtMa_HDB.Name = "txtMa_HDB";
            this.txtMa_HDB.Size = new System.Drawing.Size(100, 20);
            this.txtMa_HDB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Hóa đơn bán hàng";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(770, 291);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 34);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView_HDB
            // 
            this.dataGridView_HDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HDB.Location = new System.Drawing.Point(90, 277);
            this.dataGridView_HDB.Name = "dataGridView_HDB";
            this.dataGridView_HDB.Size = new System.Drawing.Size(674, 150);
            this.dataGridView_HDB.TabIndex = 40;
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(736, 447);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(124, 20);
            this.txtTongtien.TabIndex = 41;
            this.txtTongtien.TextChanged += new System.EventHandler(this.txtTongtien_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(644, 448);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 43;
            this.label12.Text = "Tổng tiền";
            // 
            // frmHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ktra2_QuanlyMT.Properties.Resources.Tổng_hợp_các_mẫu_background_mây_đẹp_nhất_10;
            this.ClientSize = new System.Drawing.Size(915, 504);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.dataGridView_HDB);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbChitiet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmHDB";
            this.Text = "frmHDN";
            this.Load += new System.EventHandler(this.frmHDB_Load);
            this.grbChitiet.ResumeLayout(false);
            this.grbChitiet.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbChitiet;
        private System.Windows.Forms.Label labels;
        private System.Windows.Forms.TextBox txtSo_luong;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.TextBox txtTen_mayVT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMa_HDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.ComboBox cboMa_mayVT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDon_gia;
        private System.Windows.Forms.TextBox txtTong_tien;
        private System.Windows.Forms.DataGridView dataGridView_HDB;
        private System.Windows.Forms.TextBox txtBaohanh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label12;
    }
}