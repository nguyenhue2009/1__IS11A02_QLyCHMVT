namespace Ktra2_QuanlyMT.Forms
{
    partial class frmHDN
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.dtpNgay_nhap = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMahoadon = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.grbChitiet = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenmaytinh = new System.Windows.Forms.TextBox();
            this.cboMamayvitinh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThanh_tien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDon_gia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSo_luong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_HDN = new System.Windows.Forms.DataGridView();
            this.txtTong_tien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.grbChitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HDN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTenNCC);
            this.groupBox3.Controls.Add(this.txtTenNV);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cboMaNCC);
            this.groupBox3.Controls.Add(this.cboMaNV);
            this.groupBox3.Controls.Add(this.dtpNgay_nhap);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtMahoadon);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(105, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(815, 105);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chung";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(617, 66);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(143, 20);
            this.txtTenNCC.TabIndex = 17;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(617, 31);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(143, 20);
            this.txtTenNV.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(518, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Nhà Cung Cấp ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(518, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Tên Nhân Viên";
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(342, 70);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(121, 21);
            this.cboMaNCC.TabIndex = 13;
            this.cboMaNCC.DropDown += new System.EventHandler(this.cboMaNCC_DropDown);
            this.cboMaNCC.TextChanged += new System.EventHandler(this.cboMaNCC_TextChanged);
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(342, 33);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(121, 21);
            this.cboMaNV.TabIndex = 12;
            this.cboMaNV.DropDown += new System.EventHandler(this.cboMaNV_DropDown);
            this.cboMaNV.TextChanged += new System.EventHandler(this.cboMaNV_TextChanged);
            // 
            // dtpNgay_nhap
            // 
            this.dtpNgay_nhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay_nhap.Location = new System.Drawing.Point(104, 75);
            this.dtpNgay_nhap.Name = "dtpNgay_nhap";
            this.dtpNgay_nhap.Size = new System.Drawing.Size(100, 20);
            this.dtpNgay_nhap.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(18, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 16);
            this.label15.TabIndex = 10;
            this.label15.Text = "Ngày nhập";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(261, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 16);
            this.label16.TabIndex = 8;
            this.label16.Text = "Mã NCC";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(261, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 16);
            this.label17.TabIndex = 6;
            this.label17.Text = "Mã NV";
            // 
            // txtMahoadon
            // 
            this.txtMahoadon.Location = new System.Drawing.Point(104, 32);
            this.txtMahoadon.Name = "txtMahoadon";
            this.txtMahoadon.Size = new System.Drawing.Size(100, 20);
            this.txtMahoadon.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(18, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "Mã HDN";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(861, 321);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 34);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(496, 503);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 34);
            this.btnDong.TabIndex = 37;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(361, 503);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 34);
            this.btnHuy.TabIndex = 36;
            this.btnHuy.Text = "Huy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(230, 503);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 34);
            this.btnLuu.TabIndex = 35;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // grbChitiet
            // 
            this.grbChitiet.Controls.Add(this.label2);
            this.grbChitiet.Controls.Add(this.txtTenmaytinh);
            this.grbChitiet.Controls.Add(this.cboMamayvitinh);
            this.grbChitiet.Controls.Add(this.label6);
            this.grbChitiet.Controls.Add(this.txtThanh_tien);
            this.grbChitiet.Controls.Add(this.label7);
            this.grbChitiet.Controls.Add(this.txtDon_gia);
            this.grbChitiet.Controls.Add(this.label8);
            this.grbChitiet.Controls.Add(this.txtSo_luong);
            this.grbChitiet.Controls.Add(this.label9);
            this.grbChitiet.Location = new System.Drawing.Point(105, 204);
            this.grbChitiet.Name = "grbChitiet";
            this.grbChitiet.Size = new System.Drawing.Size(815, 93);
            this.grbChitiet.TabIndex = 31;
            this.grbChitiet.TabStop = false;
            this.grbChitiet.Text = "Thông tin chi tiết nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên máy tính";
            // 
            // txtTenmaytinh
            // 
            this.txtTenmaytinh.Location = new System.Drawing.Point(417, 23);
            this.txtTenmaytinh.Name = "txtTenmaytinh";
            this.txtTenmaytinh.Size = new System.Drawing.Size(121, 20);
            this.txtTenmaytinh.TabIndex = 19;
            // 
            // cboMamayvitinh
            // 
            this.cboMamayvitinh.FormattingEnabled = true;
            this.cboMamayvitinh.Location = new System.Drawing.Point(125, 22);
            this.cboMamayvitinh.Name = "cboMamayvitinh";
            this.cboMamayvitinh.Size = new System.Drawing.Size(121, 21);
            this.cboMamayvitinh.TabIndex = 18;
            this.cboMamayvitinh.DropDown += new System.EventHandler(this.cboMamayvitinh_DropDown);
            this.cboMamayvitinh.SelectedIndexChanged += new System.EventHandler(this.cboMamayvitinh_SelectedIndexChanged);
            this.cboMamayvitinh.TextChanged += new System.EventHandler(this.cboMamayvitinh_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Số lượng";
            // 
            // txtThanh_tien
            // 
            this.txtThanh_tien.Location = new System.Drawing.Point(680, 66);
            this.txtThanh_tien.Name = "txtThanh_tien";
            this.txtThanh_tien.Size = new System.Drawing.Size(114, 20);
            this.txtThanh_tien.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(594, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Thành tiền";
            // 
            // txtDon_gia
            // 
            this.txtDon_gia.Location = new System.Drawing.Point(417, 66);
            this.txtDon_gia.Name = "txtDon_gia";
            this.txtDon_gia.Size = new System.Drawing.Size(114, 20);
            this.txtDon_gia.TabIndex = 15;
            this.txtDon_gia.TextChanged += new System.EventHandler(this.txtDon_gia_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(330, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Đơn giá";
            // 
            // txtSo_luong
            // 
            this.txtSo_luong.Location = new System.Drawing.Point(125, 66);
            this.txtSo_luong.Name = "txtSo_luong";
            this.txtSo_luong.Size = new System.Drawing.Size(121, 20);
            this.txtSo_luong.TabIndex = 13;
            this.txtSo_luong.TextChanged += new System.EventHandler(this.txtSo_luong_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Mã Máy VT";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(111, 503);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 34);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Hóa đơn nhập hàng ";
            // 
            // dataGridView_HDN
            // 
            this.dataGridView_HDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HDN.Location = new System.Drawing.Point(105, 321);
            this.dataGridView_HDN.Name = "dataGridView_HDN";
            this.dataGridView_HDN.Size = new System.Drawing.Size(736, 150);
            this.dataGridView_HDN.TabIndex = 39;
            // 
            // txtTong_tien
            // 
            this.txtTong_tien.Location = new System.Drawing.Point(753, 509);
            this.txtTong_tien.Name = "txtTong_tien";
            this.txtTong_tien.Size = new System.Drawing.Size(100, 20);
            this.txtTong_tien.TabIndex = 33;
            this.txtTong_tien.TextChanged += new System.EventHandler(this.txtTong_tien_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(667, 513);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Tổng tiền";
            // 
            // frmHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 593);
            this.Controls.Add(this.dataGridView_HDN);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTong_tien);
            this.Controls.Add(this.grbChitiet);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Name = "frmHDN";
            this.Text = "frmHDB";
            this.Load += new System.EventHandler(this.frmHDB_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grbChitiet.ResumeLayout(false);
            this.grbChitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboMaNCC;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgay_nhap;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMahoadon;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox grbChitiet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDon_gia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSo_luong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMamayvitinh;
        private System.Windows.Forms.DataGridView dataGridView_HDN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenmaytinh;
        private System.Windows.Forms.TextBox txtThanh_tien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTong_tien;
        private System.Windows.Forms.Label label10;
    }
}