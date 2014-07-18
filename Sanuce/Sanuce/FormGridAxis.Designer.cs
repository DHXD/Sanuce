namespace Sanuce
{
    partial class FormGridAxis
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoaTrucDoc = new System.Windows.Forms.Button();
            this.btnSuaTrucDoc = new System.Windows.Forms.Button();
            this.btnThemTrucDoc = new System.Windows.Forms.Button();
            this.listBoxTrucDoc = new System.Windows.Forms.ListBox();
            this.TxtKhoangCachTrucY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonXoaTrucNgang = new System.Windows.Forms.Button();
            this.buttonSuaTrucNgang = new System.Windows.Forms.Button();
            this.buttonThemTrucNgang = new System.Windows.Forms.Button();
            this.listBoxTrucNgang = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtKhoangCachTrucX = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXuatBanVe = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoaTrucDoc);
            this.groupBox2.Controls.Add(this.btnSuaTrucDoc);
            this.groupBox2.Controls.Add(this.btnThemTrucDoc);
            this.groupBox2.Controls.Add(this.listBoxTrucDoc);
            this.groupBox2.Controls.Add(this.TxtKhoangCachTrucY);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(247, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 312);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hệ trục theo phương Y";
            // 
            // btnXoaTrucDoc
            // 
            this.btnXoaTrucDoc.Location = new System.Drawing.Point(141, 270);
            this.btnXoaTrucDoc.Name = "btnXoaTrucDoc";
            this.btnXoaTrucDoc.Size = new System.Drawing.Size(59, 23);
            this.btnXoaTrucDoc.TabIndex = 13;
            this.btnXoaTrucDoc.Text = "Xóa";
            this.btnXoaTrucDoc.UseVisualStyleBackColor = true;
            this.btnXoaTrucDoc.Click += new System.EventHandler(this.btnXoaTrucDoc_Click);
            // 
            // btnSuaTrucDoc
            // 
            this.btnSuaTrucDoc.Location = new System.Drawing.Point(74, 270);
            this.btnSuaTrucDoc.Name = "btnSuaTrucDoc";
            this.btnSuaTrucDoc.Size = new System.Drawing.Size(59, 23);
            this.btnSuaTrucDoc.TabIndex = 12;
            this.btnSuaTrucDoc.Text = "Sửa";
            this.btnSuaTrucDoc.UseVisualStyleBackColor = true;
            this.btnSuaTrucDoc.Click += new System.EventHandler(this.btnSuaTrucDoc_Click);
            // 
            // btnThemTrucDoc
            // 
            this.btnThemTrucDoc.Location = new System.Drawing.Point(9, 270);
            this.btnThemTrucDoc.Name = "btnThemTrucDoc";
            this.btnThemTrucDoc.Size = new System.Drawing.Size(59, 23);
            this.btnThemTrucDoc.TabIndex = 11;
            this.btnThemTrucDoc.Text = "Thêm";
            this.btnThemTrucDoc.UseVisualStyleBackColor = true;
            this.btnThemTrucDoc.Click += new System.EventHandler(this.btnThemTrucDoc_Click);
            // 
            // listBoxTrucDoc
            // 
            this.listBoxTrucDoc.FormattingEnabled = true;
            this.listBoxTrucDoc.Location = new System.Drawing.Point(6, 72);
            this.listBoxTrucDoc.Name = "listBoxTrucDoc";
            this.listBoxTrucDoc.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxTrucDoc.Size = new System.Drawing.Size(193, 173);
            this.listBoxTrucDoc.TabIndex = 7;
            this.listBoxTrucDoc.SelectedIndexChanged += new System.EventHandler(this.listBoxTrucDoc_SelectedIndexChanged);
            // 
            // TxtKhoangCachTrucY
            // 
            this.TxtKhoangCachTrucY.Location = new System.Drawing.Point(116, 34);
            this.TxtKhoangCachTrucY.Name = "TxtKhoangCachTrucY";
            this.TxtKhoangCachTrucY.Size = new System.Drawing.Size(84, 20);
            this.TxtKhoangCachTrucY.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Khoảng cách trục:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonXoaTrucNgang);
            this.groupBox1.Controls.Add(this.buttonSuaTrucNgang);
            this.groupBox1.Controls.Add(this.buttonThemTrucNgang);
            this.groupBox1.Controls.Add(this.listBoxTrucNgang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtKhoangCachTrucX);
            this.groupBox1.Location = new System.Drawing.Point(33, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 312);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hệ trục theo phương X";
            // 
            // buttonXoaTrucNgang
            // 
            this.buttonXoaTrucNgang.Location = new System.Drawing.Point(140, 270);
            this.buttonXoaTrucNgang.Name = "buttonXoaTrucNgang";
            this.buttonXoaTrucNgang.Size = new System.Drawing.Size(59, 23);
            this.buttonXoaTrucNgang.TabIndex = 9;
            this.buttonXoaTrucNgang.Text = "Xóa";
            this.buttonXoaTrucNgang.UseVisualStyleBackColor = true;
            this.buttonXoaTrucNgang.Click += new System.EventHandler(this.buttonXoaTrucNgang_Click);
            // 
            // buttonSuaTrucNgang
            // 
            this.buttonSuaTrucNgang.Location = new System.Drawing.Point(74, 270);
            this.buttonSuaTrucNgang.Name = "buttonSuaTrucNgang";
            this.buttonSuaTrucNgang.Size = new System.Drawing.Size(59, 23);
            this.buttonSuaTrucNgang.TabIndex = 8;
            this.buttonSuaTrucNgang.Text = "Sửa";
            this.buttonSuaTrucNgang.UseVisualStyleBackColor = true;
            this.buttonSuaTrucNgang.Click += new System.EventHandler(this.buttonSuaTrucNgang_Click);
            // 
            // buttonThemTrucNgang
            // 
            this.buttonThemTrucNgang.Location = new System.Drawing.Point(7, 270);
            this.buttonThemTrucNgang.Name = "buttonThemTrucNgang";
            this.buttonThemTrucNgang.Size = new System.Drawing.Size(59, 23);
            this.buttonThemTrucNgang.TabIndex = 7;
            this.buttonThemTrucNgang.Text = "Thêm";
            this.buttonThemTrucNgang.UseVisualStyleBackColor = true;
            this.buttonThemTrucNgang.Click += new System.EventHandler(this.buttonThemTrucNgang_Click);
            // 
            // listBoxTrucNgang
            // 
            this.listBoxTrucNgang.FormattingEnabled = true;
            this.listBoxTrucNgang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBoxTrucNgang.Location = new System.Drawing.Point(7, 74);
            this.listBoxTrucNgang.Name = "listBoxTrucNgang";
            this.listBoxTrucNgang.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxTrucNgang.Size = new System.Drawing.Size(192, 173);
            this.listBoxTrucNgang.TabIndex = 6;
            this.listBoxTrucNgang.SelectedIndexChanged += new System.EventHandler(this.listBoxTrucNgang_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Khoảng cách trục:";
            // 
            // TxtKhoangCachTrucX
            // 
            this.TxtKhoangCachTrucX.Location = new System.Drawing.Point(116, 34);
            this.TxtKhoangCachTrucX.Name = "TxtKhoangCachTrucX";
            this.TxtKhoangCachTrucX.Size = new System.Drawing.Size(84, 20);
            this.TxtKhoangCachTrucX.TabIndex = 0;
            this.TxtKhoangCachTrucX.TextChanged += new System.EventHandler(this.txtKhoangCachTrucX_TextChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(364, 358);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 25);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXuatBanVe
            // 
            this.btnXuatBanVe.Location = new System.Drawing.Point(247, 358);
            this.btnXuatBanVe.Name = "btnXuatBanVe";
            this.btnXuatBanVe.Size = new System.Drawing.Size(107, 24);
            this.btnXuatBanVe.TabIndex = 7;
            this.btnXuatBanVe.Text = "Cập nhật bản vẽ";
            this.btnXuatBanVe.UseVisualStyleBackColor = true;
            this.btnXuatBanVe.Click += new System.EventHandler(this.btnXuatBanVe_Click);
            // 
            // FormGridAxis
            // 
            this.AcceptButton = this.btnXuatBanVe;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 400);
            this.Controls.Add(this.btnXuatBanVe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGridAxis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vẽ lưới trục";
            this.Load += new System.EventHandler(this.FormDrawGridAxis_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaTrucDoc;
        private System.Windows.Forms.Button btnSuaTrucDoc;
        private System.Windows.Forms.Button btnThemTrucDoc;
        private System.Windows.Forms.TextBox TxtKhoangCachTrucY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonXoaTrucNgang;
        private System.Windows.Forms.Button buttonSuaTrucNgang;
        private System.Windows.Forms.Button buttonThemTrucNgang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtKhoangCachTrucX;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXuatBanVe;
        public System.Windows.Forms.ListBox listBoxTrucDoc;
        public System.Windows.Forms.ListBox listBoxTrucNgang;
    }
}