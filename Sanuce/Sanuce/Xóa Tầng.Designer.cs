﻿namespace Sanuce
{
    partial class Xóa_Tầng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xóa_Tầng));
            this.buttonDongY = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textXoa = new System.Windows.Forms.TextBox();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDongY
            // 
            this.buttonDongY.Location = new System.Drawing.Point(113, 66);
            this.buttonDongY.Name = "buttonDongY";
            this.buttonDongY.Size = new System.Drawing.Size(75, 23);
            this.buttonDongY.TabIndex = 0;
            this.buttonDongY.Text = "&Đồng ý";
            this.buttonDongY.UseVisualStyleBackColor = true;
            this.buttonDongY.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tầng cần &Xóa:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textXoa
            // 
            this.textXoa.Location = new System.Drawing.Point(136, 19);
            this.textXoa.Name = "textXoa";
            this.textXoa.Size = new System.Drawing.Size(150, 20);
            this.textXoa.TabIndex = 2;
            this.textXoa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonHuy
            // 
            this.buttonHuy.Location = new System.Drawing.Point(211, 66);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(75, 23);
            this.buttonHuy.TabIndex = 3;
            this.buttonHuy.Text = "&Hủy";
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(20, 66);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 4;
            this.buttonXoa.Text = "&Xóa tất cả";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.button3_Click);
            // 
            // Xóa_Tầng
            // 
            this.AcceptButton = this.buttonDongY;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 111);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.textXoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDongY);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Xóa_Tầng";
            this.Text = "Xóa Tầng";
            this.Load += new System.EventHandler(this.Xóa_Tầng_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDongY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textXoa;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonXoa;
    }
}