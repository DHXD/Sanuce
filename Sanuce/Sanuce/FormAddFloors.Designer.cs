namespace Sanuce
{
    partial class FormAddFloors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddFloors));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtThemTang = new System.Windows.Forms.TextBox();
            this.TxtCao = new System.Windows.Forms.TextBox();
            this.buttonDongY = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tầng cần Thêm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Chiều cao:";
            // 
            // TxtThemTang
            // 
            this.TxtThemTang.Location = new System.Drawing.Point(165, 21);
            this.TxtThemTang.Name = "TxtThemTang";
            this.TxtThemTang.Size = new System.Drawing.Size(154, 20);
            this.TxtThemTang.TabIndex = 2;
            this.TxtThemTang.TextChanged += new System.EventHandler(this.txtThemTang_TextChanged);
            // 
            // TxtCao
            // 
            this.TxtCao.Location = new System.Drawing.Point(165, 60);
            this.TxtCao.Name = "TxtCao";
            this.TxtCao.Size = new System.Drawing.Size(154, 20);
            this.TxtCao.TabIndex = 3;
            this.TxtCao.TextChanged += new System.EventHandler(this.textCao_TextChanged);
            // 
            // buttonDongY
            // 
            this.buttonDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDongY.Location = new System.Drawing.Point(149, 106);
            this.buttonDongY.Name = "buttonDongY";
            this.buttonDongY.Size = new System.Drawing.Size(75, 23);
            this.buttonDongY.TabIndex = 4;
            this.buttonDongY.Text = "&Đồng ý";
            this.buttonDongY.UseVisualStyleBackColor = true;
            this.buttonDongY.Click += new System.EventHandler(this.buttonDongY_Click);
            // 
            // buttonHuy
            // 
            this.buttonHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.Location = new System.Drawing.Point(244, 106);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(75, 23);
            this.buttonHuy.TabIndex = 5;
            this.buttonHuy.Text = "&Hủy";
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "(mm)";
            // 
            // FormAddFloors
            // 
            this.AcceptButton = this.buttonDongY;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonHuy;
            this.ClientSize = new System.Drawing.Size(358, 147);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonDongY);
            this.Controls.Add(this.TxtCao);
            this.Controls.Add(this.TxtThemTang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddFloors";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm Tầng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCao;
        private System.Windows.Forms.Button buttonDongY;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.TextBox TxtThemTang;
        private System.Windows.Forms.Label label3;
    }
}