namespace ogrenciBilgiSistemi
{
    partial class FormOgrenci
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.dgvDersler = new System.Windows.Forms.DataGridView();
            this.btnBilgi = new System.Windows.Forms.Button();
            this.btnNot = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblOgrNo = new System.Windows.Forms.Label();
            this.lblSinif = new System.Windows.Forms.Label();
            this.lblAdS = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(343, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoşgeldiniz,";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.Transparent;
            this.lblAd.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(449, 211);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(94, 19);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Hoşgeldiniz";
            // 
            // dgvDersler
            // 
            this.dgvDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDersler.Location = new System.Drawing.Point(3, 3);
            this.dgvDersler.Name = "dgvDersler";
            this.dgvDersler.Size = new System.Drawing.Size(273, 285);
            this.dgvDersler.TabIndex = 2;
            // 
            // btnBilgi
            // 
            this.btnBilgi.Location = new System.Drawing.Point(369, 274);
            this.btnBilgi.Name = "btnBilgi";
            this.btnBilgi.Size = new System.Drawing.Size(160, 59);
            this.btnBilgi.TabIndex = 3;
            this.btnBilgi.Text = "Bilgilerimi Görüntüle";
            this.btnBilgi.UseVisualStyleBackColor = true;
            this.btnBilgi.Click += new System.EventHandler(this.btnBilgi_Click);
            // 
            // btnNot
            // 
            this.btnNot.Location = new System.Drawing.Point(369, 363);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(160, 59);
            this.btnNot.TabIndex = 4;
            this.btnNot.Text = "Notlarımı Göster";
            this.btnNot.UseVisualStyleBackColor = true;
            this.btnNot.Click += new System.EventHandler(this.btnNot_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(403, 461);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(94, 24);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGeri);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblKullaniciAdi);
            this.panel1.Controls.Add(this.lblOgrNo);
            this.panel1.Controls.Add(this.lblSinif);
            this.panel1.Controls.Add(this.lblAdS);
            this.panel1.Location = new System.Drawing.Point(312, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 334);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(100, 298);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "Geri Dön";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bilgilerim";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(29, 261);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(93, 17);
            this.lblKullaniciAdi.TabIndex = 5;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblOgrNo
            // 
            this.lblOgrNo.AutoSize = true;
            this.lblOgrNo.BackColor = System.Drawing.Color.Transparent;
            this.lblOgrNo.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrNo.Location = new System.Drawing.Point(29, 201);
            this.lblOgrNo.Name = "lblOgrNo";
            this.lblOgrNo.Size = new System.Drawing.Size(87, 17);
            this.lblOgrNo.TabIndex = 3;
            this.lblOgrNo.Text = "Öğrenci No:";
            // 
            // lblSinif
            // 
            this.lblSinif.AutoSize = true;
            this.lblSinif.BackColor = System.Drawing.Color.Transparent;
            this.lblSinif.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSinif.Location = new System.Drawing.Point(29, 140);
            this.lblSinif.Name = "lblSinif";
            this.lblSinif.Size = new System.Drawing.Size(42, 17);
            this.lblSinif.TabIndex = 1;
            this.lblSinif.Text = "Sınıf:";
            // 
            // lblAdS
            // 
            this.lblAdS.AutoSize = true;
            this.lblAdS.BackColor = System.Drawing.Color.Transparent;
            this.lblAdS.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdS.Location = new System.Drawing.Point(29, 79);
            this.lblAdS.Name = "lblAdS";
            this.lblAdS.Size = new System.Drawing.Size(76, 17);
            this.lblAdS.TabIndex = 0;
            this.lblAdS.Text = "Ad Soyad:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dgvDersler);
            this.panel2.Location = new System.Drawing.Point(312, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 342);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ogrenciBilgiSistemi.Properties.Resources.ogr_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 521);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnNot);
            this.Controls.Add(this.btnBilgi);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "FormOgrenci";
            this.Text = "FormOgrenci";
            this.Load += new System.EventHandler(this.FormOgrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.DataGridView dgvDersler;
        private System.Windows.Forms.Button btnBilgi;
        private System.Windows.Forms.Button btnNot;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdS;
        private System.Windows.Forms.Label lblSinif;
        private System.Windows.Forms.Label lblOgrNo;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}