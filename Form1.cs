using OgrenciBilgiSistemi;
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
    public partial class anaMenu : Form
    {

        public List<Ogrenci> Ogrenciler = new List<Ogrenci>();
        public List<Ogretmen> Ogretmenler = new List<Ogretmen>();
        public anaMenu()
        {
            InitializeComponent();
            SahteVeriOlustur();
        }

        private void SahteVeriOlustur()
        {
            Ogrenciler.Add(new Ogrenci
            {
                AdSoyad = "Mustafa Tümsek",
                KullaniciAdi = "mtumsek22",
                sinif = "3",
                Sifre = "2326",
                OgrenciNo = "202201",
                AlinanDersler = new List<Ders>
            {
                new Ders { DersAdi = "OOP", Not = 0 },
                new Ders { DersAdi = "Veri Tabanı", Not = 0 },
                new Ders { DersAdi = "Programlamaya Giriş", Not = 0 },
                new Ders { DersAdi = "Veri Yapıları", Not = 0 }
            }
            });

            Ogrenciler.Add(new Ogrenci
            {
                AdSoyad = "Selin Yılmaz",
                KullaniciAdi = "syilmaz23",
                sinif = "2",
                Sifre = "2353",
                OgrenciNo = "202301",
                AlinanDersler = new List<Ders>
            {
                new Ders { DersAdi = "OOP", Not = 0 },
                new Ders { DersAdi = "Veri Tabanı", Not = 0 },
                new Ders { DersAdi = "Programlamaya Giriş", Not = 0 },
                new Ders { DersAdi = "Veri Yapıları", Not = 0 }
            }
            });

            Ogretmenler.Add(new Ogretmen
            {
                AdSoyad = "Ömer Güleç",
                KullaniciAdi = "ogulec",
                unvan = "Prof. Dr.",
                Sifre = "1111",
                SicilNo = "OG123"
            });
        }



        private void anaMenu_Load(object sender, EventArgs e)
        {
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullanici = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            var ogr = Ogrenciler.FirstOrDefault(o => o.KullaniciAdi == kullanici && o.Sifre == sifre);
            if (ogr != null)
            {
                FormOgrenci frmOgrenci = new FormOgrenci(ogr);
                frmOgrenci.Show();
                //this.Hide();
                return;
            }

            var ogret = Ogretmenler.FirstOrDefault(o => o.KullaniciAdi == kullanici && o.Sifre == sifre);
            if (ogret != null)
            {
                FormOgretmen frmOgretmen = new FormOgretmen(ogret, Ogrenciler);
                frmOgretmen.Show();
                //this.Hide();
                return;
            }

            MessageBox.Show("Kullanıcı adı veya şifre yanlış, lütfen tekrar deneyiniz.","Hata");
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)  //sadece sayı girişi
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
