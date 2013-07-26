namespace Sanuce
{
    partial class FormEditTang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditTang));
            this.txtSua = new System.Windows.Forms.TextBox();
            this.buttonDongY = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.txtNCao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSua
            // 
            this.txtSua.Location = new System.Drawing.Point(139, 22);
            this.txtSua.Name = "txtSua";
            this.txtSua.ReadOnly = true;
            this.txtSua.Size = new System.Drawing.Size(151, 20);
            this.txtSua.TabIndex = 0;
            this.txtSua.TabStop = false;
            this.txtSua.TextChanged += new System.EventHandler(this.txtSua_TextChanged);
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
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tầng cần Sửa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập Chiều cao:";
            // 
            // buttonHuy
            // 
            this.buttonHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonHuy.Location = new System.Drawing.Point(215, 100);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(75, 23);
            this.buttonHuy.TabIndex = 4;
            this.buttonHuy.Text = "&Hủy";
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNCao
            // 
            this.txtNCao.Location = new System.Drawing.Point(139, 61);
            this.txtNCao.Name = "txtNCao";
            this.txtNCao.Size = new System.Drawing.Size(151, 20);
            this.txtNCao.TabIndex = 0;
            this.txtNCao.TextChanged += new System.EventHandler(this.textNCao_TextChanged);
            // 
            // FormEditTang
            // 
            this.AcceptButton = this.buttonDongY;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonHuy;
            this.ClientSize = new System.Drawing.Size(313, 140);
            this.Controls.Add(this.txtNCao);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDongY);
            this.Controls.Add(this.txtSua);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditTang";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa Tầng";
            this.Load += new System.EventHandler(this.Sửa_Tâng_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSua;
        private System.Windows.Forms.Button buttonDongY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.TextBox txtNCao;
    }
}