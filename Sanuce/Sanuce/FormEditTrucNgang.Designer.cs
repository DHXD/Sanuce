namespace Sanuce
{
    partial class FormEditTrucNgang
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
            this.txtTrucCanSua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNKhoangCach = new System.Windows.Forms.TextBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTrucCanSua
            // 
            this.txtTrucCanSua.Location = new System.Drawing.Point(166, 32);
            this.txtTrucCanSua.Name = "txtTrucCanSua";
            this.txtTrucCanSua.ReadOnly = true;
            this.txtTrucCanSua.Size = new System.Drawing.Size(152, 20);
            this.txtTrucCanSua.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trục cần Sửa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập Khoảng cách:";
            // 
            // txtNKhoangCach
            // 
            this.txtNKhoangCach.Location = new System.Drawing.Point(166, 78);
            this.txtNKhoangCach.Name = "txtNKhoangCach";
            this.txtNKhoangCach.Size = new System.Drawing.Size(152, 20);
            this.txtNKhoangCach.TabIndex = 0;
            this.txtNKhoangCach.TextChanged += new System.EventHandler(this.txtNKhoangCach_TextChanged);
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(127, 123);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(81, 23);
            this.btnDongY.TabIndex = 1;
            this.btnDongY.Text = "&Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(235, 123);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(81, 22);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "(mm)";
            // 
            // FormEditTrucNgang
            // 
            this.AcceptButton = this.btnDongY;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 167);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtNKhoangCach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTrucCanSua);
            this.Name = "FormEditTrucNgang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa Trục Ngang";
            this.Load += new System.EventHandler(this.FormEditTrucNgang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTrucCanSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNKhoangCach;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label3;
    }
}