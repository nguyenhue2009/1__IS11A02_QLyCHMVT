namespace Ktra2_QuanlyMT.Forms
{
    partial class frmBCHDB
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
            this.btnTheonam = new System.Windows.Forms.Button();
            this.btnTheoQuy = new System.Windows.Forms.Button();
            this.btnTheothang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Báo Cáo Bán Hàng";
            // 
            // btnTheonam
            // 
            this.btnTheonam.Location = new System.Drawing.Point(459, 103);
            this.btnTheonam.Name = "btnTheonam";
            this.btnTheonam.Size = new System.Drawing.Size(129, 79);
            this.btnTheonam.TabIndex = 13;
            this.btnTheonam.Text = "Theo Năm";
            this.btnTheonam.UseVisualStyleBackColor = true;
            this.btnTheonam.Click += new System.EventHandler(this.btnTheonam_Click);
            // 
            // btnTheoQuy
            // 
            this.btnTheoQuy.Location = new System.Drawing.Point(242, 103);
            this.btnTheoQuy.Name = "btnTheoQuy";
            this.btnTheoQuy.Size = new System.Drawing.Size(129, 79);
            this.btnTheoQuy.TabIndex = 12;
            this.btnTheoQuy.Text = "Theo Quý ";
            this.btnTheoQuy.UseVisualStyleBackColor = true;
            this.btnTheoQuy.Click += new System.EventHandler(this.btnTheoQuy_Click);
            // 
            // btnTheothang
            // 
            this.btnTheothang.Location = new System.Drawing.Point(25, 103);
            this.btnTheothang.Name = "btnTheothang";
            this.btnTheothang.Size = new System.Drawing.Size(129, 79);
            this.btnTheothang.TabIndex = 11;
            this.btnTheothang.Text = "Theo Tháng ";
            this.btnTheothang.UseVisualStyleBackColor = true;
            this.btnTheothang.Click += new System.EventHandler(this.btnTheothang_Click);
            // 
            // frmBCHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 290);
            this.Controls.Add(this.btnTheonam);
            this.Controls.Add(this.btnTheoQuy);
            this.Controls.Add(this.btnTheothang);
            this.Controls.Add(this.label1);
            this.Name = "frmBCHDB";
            this.Text = "frmBCHDB";
            this.Load += new System.EventHandler(this.frmBCHDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTheonam;
        private System.Windows.Forms.Button btnTheoQuy;
        private System.Windows.Forms.Button btnTheothang;
    }
}