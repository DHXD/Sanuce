namespace Sanuce
{
    partial class Sửa_Tâng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sửa_Tâng));
            this.textSua = new System.Windows.Forms.TextBox();
            this.buttonDongY = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.textNCao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textSua
            // 
            this.textSua.Location = new System.Drawing.Point(139, 22);
            this.textSua.Name = "textSua";
            this.textSua.Size = new System.Drawing.Size(151, 20);
            this.textSua.TabIndex = 0;
            // 
            // buttonDongY
            // 
            this.buttonDongY.Location = new System.Drawing.Point(118, 100);
            this.buttonDongY.Name = "buttonDongY";
            this.buttonDongY.Size = new System.Drawing.Size(75, 23);
            this.buttonDongY.TabIndex = 1;
            this.buttonDongY.Text = "&Đồng ý";
            this.buttonDongY.UseVisualStyleBackColor = true;
            this.buttonDongY.Click += new System.EventHandler(this.buttonDongY_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập tầng cần &Sửa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập &Chiều cao:";
            // 
            // buttonHuy
            // 
            this.buttonHuy.Location = new System.Drawing.Point(215, 100);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(75, 23);
            this.buttonHuy.TabIndex = 4;
            this.buttonHuy.Text = "&Hủy";
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.button2_Click);
            // 
            // textNCao
            // 
            this.textNCao.Location = new System.Drawing.Point(139, 61);
            this.textNCao.Name = "textNCao";
            this.textNCao.Size = new System.Drawing.Size(151, 20);
            this.textNCao.TabIndex = 5;
            // 
            // Sửa_Tâng
            // 
            this.AcceptButton = this.buttonDongY;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 140);
            this.Controls.Add(this.textNCao);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDongY);
            this.Controls.Add(this.textSua);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sửa_Tâng";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Sửa_Tâng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSua;
        private System.Windows.Forms.Button buttonDongY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.TextBox textNCao;
    }
}