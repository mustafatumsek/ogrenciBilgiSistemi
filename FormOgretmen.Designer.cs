namespace OgrenciBilgiSistemi
{
    partial class FormOgretmen
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNotGir = new System.Windows.Forms.Button();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbOgrenciler = new System.Windows.Forms.ComboBox();
            this.dgvDersler = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblOgrNo = new System.Windows.Forms.Label();
            this.lblSinif = new System.Windows.Forms.Label();
            this.lblAdS = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnNot = new System.Windows.Forms.Button();
            this.btnBilgi = new System.Windows.Forms.Button();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnNotGir);
            this.panel2.Controls.Add(this.txtNot);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cmbOgrenciler);
            this.panel2.Controls.Add(this.dgvDersler);
            this.panel2.Location = new System.Drawing.Point(436, 204);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 398);
            this.panel2.TabIndex = 15;
            this.panel2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Not";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Öğrenci";
            // 
            // btnNotGir
            // 
            this.btnNotGir.Location = new System.Drawing.Point(275, 41);
            this.btnNotGir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNotGir.Name = "btnNotGir";
            this.btnNotGir.Size = new System.Drawing.Size(93, 28);
            this.btnNotGir.TabIndex = 17;
            this.btnNotGir.Text = "Kaydet";
            this.btnNotGir.UseVisualStyleBackColor = true;
            this.btnNotGir.Click += new System.EventHandler(this.btnNotGir_Click);
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(192, 42);
            this.txtNot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(73, 22);
            this.txtNot.TabIndex = 19;
            this.txtNot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNot_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 367);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbOgrenciler
            // 
            this.cmbOgrenciler.FormattingEnabled = true;
            this.cmbOgrenciler.Location = new System.Drawing.Point(23, 41);
            this.cmbOgrenciler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOgrenciler.Name = "cmbOgrenciler";
            this.cmbOgrenciler.Size = new System.Drawing.Size(160, 24);
            this.cmbOgrenciler.TabIndex = 18;
            this.cmbOgrenciler.SelectedIndexChanged += new System.EventHandler(this.cmbOgrenciler_SelectedIndexChanged);
            // 
            // dgvDersler
            // 
            this.dgvDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDersler.Location = new System.Drawing.Point(0, 74);
            this.dgvDersler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDersler.Name = "dgvDersler";
            this.dgvDersler.RowHeadersWidth = 51;
            this.dgvDersler.Size = new System.Drawing.Size(387, 286);
            this.dgvDersler.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGeri);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblKullaniciAdi);
            this.panel1.Controls.Add(this.lblOgrNo);
            this.panel1.Controls.Add(this.lblSinif);
            this.panel1.Controls.Add(this.lblAdS);
            this.panel1.Location = new System.Drawing.Point(436, 204);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 398);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(133, 367);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(100, 28);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "Geri Dön";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bilgilerim";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(39, 321);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(122, 22);
            this.lblKullaniciAdi.TabIndex = 5;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblOgrNo
            // 
            this.lblOgrNo.AutoSize = true;
            this.lblOgrNo.BackColor = System.Drawing.Color.Transparent;
            this.lblOgrNo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrNo.Location = new System.Drawing.Point(39, 247);
            this.lblOgrNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOgrNo.Name = "lblOgrNo";
            this.lblOgrNo.Size = new System.Drawing.Size(111, 22);
            this.lblOgrNo.TabIndex = 3;
            this.lblOgrNo.Text = "Öğrenci No:";
            // 
            // lblSinif
            // 
            this.lblSinif.AutoSize = true;
            this.lblSinif.BackColor = System.Drawing.Color.Transparent;
            this.lblSinif.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSinif.Location = new System.Drawing.Point(39, 172);
            this.lblSinif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSinif.Name = "lblSinif";
            this.lblSinif.Size = new System.Drawing.Size(56, 22);
            this.lblSinif.TabIndex = 1;
            this.lblSinif.Text = "Sınıf:";
            // 
            // lblAdS
            // 
            this.lblAdS.AutoSize = true;
            this.lblAdS.BackColor = System.Drawing.Color.Transparent;
            this.lblAdS.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdS.Location = new System.Drawing.Point(39, 97);
            this.lblAdS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdS.Name = "lblAdS";
            this.lblAdS.Size = new System.Drawing.Size(98, 22);
            this.lblAdS.TabIndex = 0;
            this.lblAdS.Text = "Ad Soyad:";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(568, 549);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(125, 30);
            this.btnCikis.TabIndex = 13;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnNot
            // 
            this.btnNot.Location = new System.Drawing.Point(523, 428);
            this.btnNot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(213, 73);
            this.btnNot.TabIndex = 12;
            this.btnNot.Text = "Not Girişi";
            this.btnNot.UseVisualStyleBackColor = true;
            this.btnNot.Click += new System.EventHandler(this.btnNot_Click);
            // 
            // btnBilgi
            // 
            this.btnBilgi.Location = new System.Drawing.Point(523, 319);
            this.btnBilgi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBilgi.Name = "btnBilgi";
            this.btnBilgi.Size = new System.Drawing.Size(213, 73);
            this.btnBilgi.TabIndex = 11;
            this.btnBilgi.Text = "Bilgilerimi Görüntüle";
            this.btnBilgi.UseVisualStyleBackColor = true;
            this.btnBilgi.Click += new System.EventHandler(this.btnBilgi_Click);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblAdSoyad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(629, 241);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(108, 23);
            this.lblAdSoyad.TabIndex = 10;
            this.lblAdSoyad.Text = "Hoşgeldiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(488, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hoşgeldiniz,";
            // 
            // FormOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ogrenciBilgiSistemi.Properties.Resources.hoca_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1259, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnNot);
            this.Controls.Add(this.btnBilgi);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormOgretmen";
            this.Text = "Öğretmen Bilgi Sistemi";
            this.Load += new System.EventHandler(this.FormOgretmen_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvDersler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblOgrNo;
        private System.Windows.Forms.Label lblSinif;
        private System.Windows.Forms.Label lblAdS;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnNot;
        private System.Windows.Forms.Button btnBilgi;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNotGir;
        private System.Windows.Forms.ComboBox cmbOgrenciler;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}