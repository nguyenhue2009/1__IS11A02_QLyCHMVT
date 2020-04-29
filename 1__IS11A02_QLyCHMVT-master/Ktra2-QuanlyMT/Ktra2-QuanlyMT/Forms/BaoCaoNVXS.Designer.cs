namespace Ktra2_QuanlyMT.Forms
{
    partial class BaoCaoNVXS
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
            this.btnTheothang = new System.Windows.Forms.Button();
            this.btnTheoQuy = new System.Windows.Forms.Button();
            this.btnTheonam = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTheothang
            // 
            this.btnTheothang.BackColor = System.Drawing.Color.BurlyWood;
            this.btnTheothang.Location = new System.Drawing.Point(70, 132);
            this.btnTheothang.Name = "btnTheothang";
            this.btnTheothang.Size = new System.Drawing.Size(129, 79);
            this.btnTheothang.TabIndex = 0;
            this.btnTheothang.Text = "Theo Tháng ";
            this.btnTheothang.UseVisualStyleBackColor = false;
            this.btnTheothang.Click += new System.EventHandler(this.btnTheothang_Click);
            // 
            // btnTheoQuy
            // 
            this.btnTheoQuy.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnTheoQuy.Location = new System.Drawing.Point(287, 132);
            this.btnTheoQuy.Name = "btnTheoQuy";
            this.btnTheoQuy.Size = new System.Drawing.Size(129, 79);
            this.btnTheoQuy.TabIndex = 1;
            this.btnTheoQuy.Text = "Theo Quý ";
            this.btnTheoQuy.UseVisualStyleBackColor = false;
            this.btnTheoQuy.Click += new System.EventHandler(this.btnTheoQuy_Click);
            // 
            // btnTheonam
            // 
            this.btnTheonam.BackColor = System.Drawing.Color.MintCream;
            this.btnTheonam.Location = new System.Drawing.Point(504, 132);
            this.btnTheonam.Name = "btnTheonam";
            this.btnTheonam.Size = new System.Drawing.Size(129, 79);
            this.btnTheonam.TabIndex = 2;
            this.btnTheonam.Text = "Theo Năm";
            this.btnTheonam.UseVisualStyleBackColor = false;
            this.btnTheonam.Click += new System.EventHandler(this.btnTheonam_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Danh sách Top 5 nhân viên bán nhiều nhất "});
            this.comboBox1.Location = new System.Drawing.Point(205, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lựa chọn hình thức báo cáo";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Violet;
            this.button4.Location = new System.Drawing.Point(466, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 37);
            this.button4.TabIndex = 5;
            this.button4.Text = "Next";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BaoCaoNVXS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ktra2_QuanlyMT.Properties.Resources._20_hinh_nen_powerpoint_chu_de_may_tinh_1484409500_6;
            this.ClientSize = new System.Drawing.Size(716, 255);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnTheonam);
            this.Controls.Add(this.btnTheoQuy);
            this.Controls.Add(this.btnTheothang);
            this.Name = "BaoCaoNVXS";
            this.Text = "BaoCaoNVXS";
            this.Load += new System.EventHandler(this.BaoCaoNVXS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTheothang;
        private System.Windows.Forms.Button btnTheoQuy;
        private System.Windows.Forms.Button btnTheonam;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}