namespace Ktra2_QuanlyMT.Forms
{
    partial class frmBCHDB_TheoNam_
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
            this.txtNguoinhap = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNguoinhap
            // 
            this.txtNguoinhap.Location = new System.Drawing.Point(206, 87);
            this.txtNguoinhap.Name = "txtNguoinhap";
            this.txtNguoinhap.Size = new System.Drawing.Size(121, 20);
            this.txtNguoinhap.TabIndex = 22;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(206, 46);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(121, 20);
            this.txtNam.TabIndex = 21;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(313, 160);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnBaocao
            // 
            this.btnBaocao.Location = new System.Drawing.Point(62, 160);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(75, 23);
            this.btnBaocao.TabIndex = 19;
            this.btnBaocao.Text = "Báo Cáo";
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Người Lập Báo Cáo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Năm : ";
            // 
            // frmBCHDB_TheoNam_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 213);
            this.Controls.Add(this.txtNguoinhap);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBaocao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmBCHDB_TheoNam_";
            this.Text = "frmBCHDB_TheoNam_";
            this.Load += new System.EventHandler(this.frmBCHDB_TheoNam__Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNguoinhap;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}