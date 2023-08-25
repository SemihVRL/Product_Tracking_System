namespace Urun_Takip_Sistemi
{
    partial class FrmAdmin
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
            this.BtnGiriş = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSifre = new System.Windows.Forms.TextBox();
            this.tbxKullanıcıAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKullanıcıAd = new System.Windows.Forms.Label();
            this.btnUye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGiriş
            // 
            this.BtnGiriş.Location = new System.Drawing.Point(270, 236);
            this.BtnGiriş.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGiriş.Name = "BtnGiriş";
            this.BtnGiriş.Size = new System.Drawing.Size(256, 62);
            this.BtnGiriş.TabIndex = 15;
            this.BtnGiriş.Text = "Giriş Yap";
            this.BtnGiriş.UseVisualStyleBackColor = true;
            this.BtnGiriş.UseWaitCursor = true;
            this.BtnGiriş.Click += new System.EventHandler(this.BtnGiriş_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(26, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "ÜRÜN TAKİP SİSTEMİ KULLANICI GİRİŞİ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseWaitCursor = true;
            // 
            // tbxSifre
            // 
            this.tbxSifre.Location = new System.Drawing.Point(270, 168);
            this.tbxSifre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxSifre.Name = "tbxSifre";
            this.tbxSifre.Size = new System.Drawing.Size(256, 31);
            this.tbxSifre.TabIndex = 13;
            this.tbxSifre.UseSystemPasswordChar = true;
            this.tbxSifre.UseWaitCursor = true;
            // 
            // tbxKullanıcıAdi
            // 
            this.tbxKullanıcıAdi.Location = new System.Drawing.Point(270, 117);
            this.tbxKullanıcıAdi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxKullanıcıAdi.Name = "tbxKullanıcıAdi";
            this.tbxKullanıcıAdi.Size = new System.Drawing.Size(256, 31);
            this.tbxKullanıcıAdi.TabIndex = 12;
            this.tbxKullanıcıAdi.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Şifre:";
            this.label1.UseWaitCursor = true;
            // 
            // lblKullanıcıAd
            // 
            this.lblKullanıcıAd.AutoSize = true;
            this.lblKullanıcıAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanıcıAd.Location = new System.Drawing.Point(26, 117);
            this.lblKullanıcıAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullanıcıAd.Name = "lblKullanıcıAd";
            this.lblKullanıcıAd.Size = new System.Drawing.Size(163, 31);
            this.lblKullanıcıAd.TabIndex = 10;
            this.lblKullanıcıAd.Text = "Kullanıcı Ad:";
            this.lblKullanıcıAd.UseWaitCursor = true;
            // 
            // btnUye
            // 
            this.btnUye.Location = new System.Drawing.Point(270, 308);
            this.btnUye.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUye.Name = "btnUye";
            this.btnUye.Size = new System.Drawing.Size(256, 66);
            this.btnUye.TabIndex = 9;
            this.btnUye.Text = "Üye Ol";
            this.btnUye.UseVisualStyleBackColor = true;
            this.btnUye.UseWaitCursor = true;
            this.btnUye.Click += new System.EventHandler(this.btnUye_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(553, 389);
            this.Controls.Add(this.BtnGiriş);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSifre);
            this.Controls.Add(this.tbxKullanıcıAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKullanıcıAd);
            this.Controls.Add(this.btnUye);
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGiriş;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSifre;
        private System.Windows.Forms.TextBox tbxKullanıcıAdi;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKullanıcıAd;
        private System.Windows.Forms.Button btnUye;
    }
}