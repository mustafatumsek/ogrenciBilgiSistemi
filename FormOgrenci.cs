using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenciBilgiSistemi
{
    public partial class FormOgrenci : Form
    {
        private Ogrenci ogrenci;

        public FormOgrenci(Ogrenci ogr)
        {
            InitializeComponent();
            ogrenci = ogr;
        }

        private void FormOgrenci_Load(object sender, EventArgs e)
        {
            lblAd.Text = $"{ogrenci.AdSoyad}";
            lblAdS.Text = $"Ad Soyad: {ogrenci.AdSoyad}";
            lblSinif.Text = $"Sınıf: {ogrenci.sinif}";
            lblOgrNo.Text = $"Öğrenci No:{ogrenci.OgrenciNo}";
            lblKullaniciAdi.Text = $"Kullanıcı Adı:{ogrenci.KullaniciAdi}";

            dgvDersler.AutoGenerateColumns = false;
            dgvDersler.Columns.Clear();

            dgvDersler.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ders Adı",
                DataPropertyName = "DersAdi",
                ReadOnly = true
            });

            dgvDersler.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Not",
                DataPropertyName = "Not",
                ReadOnly = true
            });

            dgvDersler.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Durum",
                DataPropertyName = "Durum",
                ReadOnly = true
            });

            dgvDersler.DataSource = ogrenci.AlinanDersler;


        }

        private void btnBilgi_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible=false;
        }
    }

}
