namespace Ktra2_QuanlyMT.Forms
{
    partial class frmBaocaohangtoncs
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNguoinhap
            // 
            this.txtNguoinhap.Location = new System.Drawing.Point(273, 135);
            this.txtNguoinhap.Name = "txtNguoinhap";
            this.txtNguoinhap.Size = new System.Drawing.Size(121, 20);
            this.txtNguoinhap.TabIndex = 15;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(273, 94);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(121, 20);
            this.txtNam.TabIndex = 14;
            this.txtNam.TextChanged += new System.EventHandler(this.txtNam_TextChanged);
            this.txtNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNam_KeyPress);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(384, 187);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnBaocao
            // 
            this.btnBaocao.Location = new System.Drawing.Point(133, 187);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(75, 23);
            this.btnBaocao.TabIndex = 12;
            this.btnBaocao.Text = "Báo Cáo";
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "BÁO CÁO HÀNG TỒN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Người Lập Báo Cáo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Năm : ";
            // 
            // frmBaocaohangtoncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 261);
            this.Controls.Add(this.txtNguoinhap);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBaocao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmBaocaohangtoncs";
            this.Text = "frmBaocaohangtoncs";
            this.Load += new System.EventHandler(this.frmBaocaohangtoncs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNguoinhap;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}