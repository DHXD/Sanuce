namespace Sanuce
{
    partial class Palette
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTang = new System.Windows.Forms.Button();
            this.listBoxTang = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTang
            // 
            this.btnTang.Location = new System.Drawing.Point(27, 25);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(75, 23);
            this.btnTang.TabIndex = 0;
            this.btnTang.Text = "&Tầng";
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxTang
            // 
            this.listBoxTang.FormattingEnabled = true;
            this.listBoxTang.Location = new System.Drawing.Point(68, 54);
            this.listBoxTang.Name = "listBoxTang";
            this.listBoxTang.Size = new System.Drawing.Size(180, 147);
            this.listBoxTang.TabIndex = 1;
            this.listBoxTang.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Palette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxTang);
            this.Controls.Add(this.btnTang);
            this.MinimumSize = new System.Drawing.Size(130, 200);
            this.Name = "Palette";
            this.Size = new System.Drawing.Size(251, 358);
            this.Load += new System.EventHandler(this.UserControlDockingPalette_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.ListBox listBoxTang;

    }
}
