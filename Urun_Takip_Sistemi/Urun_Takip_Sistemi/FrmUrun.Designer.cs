namespace Urun_Takip_Sistemi
{
    partial class FrmUrun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrun));
            this.btnAra = new System.Windows.Forms.Button();
            this.btnUrunGüncelle = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnUrunListele = new System.Windows.Forms.Button();
            this.tbxUrunID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUrunAd = new System.Windows.Forms.TextBox();
            this.tbxUrunAlıs = new System.Windows.Forms.TextBox();
            this.tbxUrunSatıs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnUrunKaydet = new System.Windows.Forms.Button();
            this.cbxKategori = new System.Windows.Forms.ComboBox();
            this.nupdownStok = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdownStok)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(3194, 1990);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(624, 202);
            this.btnAra.TabIndex = 13;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // btnUrunGüncelle
            // 
            this.btnUrunGüncelle.Location = new System.Drawing.Point(1036, 577);
            this.btnUrunGüncelle.Name = "btnUrunGüncelle";
            this.btnUrunGüncelle.Size = new System.Drawing.Size(298, 55);
            this.btnUrunGüncelle.TabIndex = 10;
            this.btnUrunGüncelle.Text = "Güncelle";
            this.btnUrunGüncelle.UseVisualStyleBackColor = true;
            this.btnUrunGüncelle.Click += new System.EventHandler(this.btnUrunGüncelle_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(1037, 517);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(297, 54);
            this.btnUrunSil.TabIndex = 9;
            this.btnUrunSil.Text = "Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnUrunListele
            // 
            this.btnUrunListele.Location = new System.Drawing.Point(1037, 390);
            this.btnUrunListele.Name = "btnUrunListele";
            this.btnUrunListele.Size = new System.Drawing.Size(297, 62);
            this.btnUrunListele.TabIndex = 7;
            this.btnUrunListele.Text = "Listele";
            this.btnUrunListele.UseVisualStyleBackColor = true;
            this.btnUrunListele.Click += new System.EventHandler(this.btnUrunListele_Click);
            // 
            // tbxUrunID
            // 
            this.tbxUrunID.Location = new System.Drawing.Point(1040, 52);
            this.tbxUrunID.Name = "tbxUrunID";
            this.tbxUrunID.Size = new System.Drawing.Size(290, 38);
            this.tbxUrunID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(870, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün ID:";
            // 
            // tbxUrunAd
            // 
            this.tbxUrunAd.Location = new System.Drawing.Point(1037, 108);
            this.tbxUrunAd.Name = "tbxUrunAd";
            this.tbxUrunAd.Size = new System.Drawing.Size(290, 38);
            this.tbxUrunAd.TabIndex = 2;
            // 
            // tbxUrunAlıs
            // 
            this.tbxUrunAlıs.Location = new System.Drawing.Point(1037, 218);
            this.tbxUrunAlıs.Name = "tbxUrunAlıs";
            this.tbxUrunAlıs.Size = new System.Drawing.Size(290, 38);
            this.tbxUrunAlıs.TabIndex = 4;
            // 
            // tbxUrunSatıs
            // 
            this.tbxUrunSatıs.Location = new System.Drawing.Point(1037, 280);
            this.tbxUrunSatıs.Name = "tbxUrunSatıs";
            this.tbxUrunSatıs.Size = new System.Drawing.Size(290, 38);
            this.tbxUrunSatıs.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(870, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ürün Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(870, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "Stok:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(874, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 31);
            this.label5.TabIndex = 28;
            this.label5.Text = "Kategoriler:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(870, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 31);
            this.label6.TabIndex = 26;
            this.label6.Text = "Satış Fiyatı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(870, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 31);
            this.label7.TabIndex = 27;
            this.label7.Text = "Alış Fiyatı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(831, 637);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-5141, -144);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1936, 1442);
            this.dataGridView2.TabIndex = 14;
            // 
            // btnUrunKaydet
            // 
            this.btnUrunKaydet.Location = new System.Drawing.Point(1036, 458);
            this.btnUrunKaydet.Name = "btnUrunKaydet";
            this.btnUrunKaydet.Size = new System.Drawing.Size(299, 53);
            this.btnUrunKaydet.TabIndex = 8;
            this.btnUrunKaydet.Text = "Kaydet";
            this.btnUrunKaydet.UseVisualStyleBackColor = true;
            this.btnUrunKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
            // 
            // cbxKategori
            // 
            this.cbxKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKategori.FormattingEnabled = true;
            this.cbxKategori.Location = new System.Drawing.Point(1036, 339);
            this.cbxKategori.Name = "cbxKategori";
            this.cbxKategori.Size = new System.Drawing.Size(291, 39);
            this.cbxKategori.TabIndex = 6;
            // 
            // nupdownStok
            // 
            this.nupdownStok.Location = new System.Drawing.Point(1040, 161);
            this.nupdownStok.Name = "nupdownStok";
            this.nupdownStok.Size = new System.Drawing.Size(287, 38);
            this.nupdownStok.TabIndex = 3;
            this.nupdownStok.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1036, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 62);
            this.button1.TabIndex = 29;
            this.button1.Text = "Ana Ekrana Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1358, 724);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nupdownStok);
            this.Controls.Add(this.cbxKategori);
            this.Controls.Add(this.btnUrunKaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxUrunSatıs);
            this.Controls.Add(this.tbxUrunAlıs);
            this.Controls.Add(this.tbxUrunID);
            this.Controls.Add(this.tbxUrunAd);
            this.Controls.Add(this.btnUrunGüncelle);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnUrunListele);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmUrun";
            this.Text = "Ürün Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdownStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnUrunGüncelle;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunListele;
        private System.Windows.Forms.TextBox tbxUrunID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUrunAd;
        private System.Windows.Forms.TextBox tbxUrunAlıs;
        private System.Windows.Forms.TextBox tbxUrunSatıs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnUrunKaydet;
        private System.Windows.Forms.ComboBox cbxKategori;
        private System.Windows.Forms.NumericUpDown nupdownStok;
        private System.Windows.Forms.Button button1;
    }
}