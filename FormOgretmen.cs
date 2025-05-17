using ogrenciBilgiSistemi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class FormOgretmen : Form
    {
        private Ogretmen ogretmen;
        private List<Ogrenci> ogrenciler;
        private Ogrenci seciliOgrenci;

        public FormOgretmen(Ogretmen ogret, List<Ogrenci> ogrList)
        {
            InitializeComponent();
            ogretmen = ogret;
            ogrenciler = ogrList;
        }

        private void FormOgretmen_Load(object sender, EventArgs e)
        {
            cmbOgrenciler.DataSource = ogrenciler;
            cmbOgrenciler.DisplayMember = "AdSoyad";
            cmbOgrenciler.ValueMember = "OgrenciNo";
            lblAdSoyad.Text = $"{ogretmen.AdSoyad}";
            lblAdS.Text = $"Ad Soyad: {ogretmen.AdSoyad}";
            lblSinif.Text = $"Unvan: {ogretmen.unvan}";
            lblOgrNo.Text = $"Sicil No:{ogretmen.SicilNo}";
            lblKullaniciAdi.Text = $"Kullanıcı Adı:{ogretmen.KullaniciAdi}";
        }

        private void cmbOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliOgrenci = cmbOgrenciler.SelectedItem as Ogrenci;

            if (seciliOgrenci != null)
            {
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
                    DataPropertyName = "Not"
                });

                dgvDersler.DataSource = null;
                dgvDersler.DataSource = seciliOgrenci.AlinanDersler;
            }
        }

        private void btnNotGir_Click(object sender, EventArgs e)
        {
            if (dgvDersler.CurrentRow != null && int.TryParse(txtNot.Text, out int girilenNot))
            {
                var seciliDers = dgvDersler.CurrentRow.DataBoundItem as Ders;
                if (seciliDers != null)
                {
                    seciliDers.Not = girilenNot;

                    // Görsel güncelleme
                    dgvDersler.Refresh();

                    MessageBox.Show("Not başarıyla girildi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir not girin.");
            }
        }

        private void btnBilgi_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible=false;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNot_KeyPress(object sender, KeyPressEventArgs e)    //sadece sayı girişi
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
