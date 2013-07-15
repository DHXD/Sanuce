namespace Sanuce
{
    partial class FormMoreFloors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMoreFloors));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textThemTang = new System.Windows.Forms.TextBox();
            this.textCao = new System.Windows.Forms.TextBox();
            this.buttonDongY = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.label1.Text = "Nhập tầng cần &Thêm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập &Chiều cao:";
            // 
            // textThemTang
            // 
            this.textThemTang.Location = new System.Drawing.Point(165, 21);
            this.textThemTang.Name = "textThemTang";
            this.textThemTang.Size = new System.Drawing.Size(154, 20);
            this.textThemTang.TabIndex = 2;
            this.textThemTang.TextChanged += new System.EventHandler(this.txtThemTang_TextChanged);
            // 
            // textCao
            // 
            this.textCao.Location = new System.Drawing.Point(165, 60);
            this.textCao.Name = "textCao";
            this.textCao.Size = new System.Drawing.Size(154, 20);
            this.textCao.TabIndex = 3;
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(244, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMoreFloors
            // 
            this.AcceptButton = this.buttonDongY;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 147);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonDongY);
            this.Controls.Add(this.textCao);
            this.Controls.Add(this.textThemTang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMoreFloors";
            this.Text = "Thêm Tầng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textThemTang;
        private System.Windows.Forms.TextBox textCao;
        private System.Windows.Forms.Button buttonDongY;
        private System.Windows.Forms.Button button2;
    }
}