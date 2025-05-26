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
            kullaniciOlustur();
        }

        private void kullaniciOlustur()
        {
            Ogrenciler.Add(new Ogrenci
            {
                AdSoyad = "Mustafa Tümsek",
                KullaniciAdi = "mtumsek22",
                sinif = "3",
                Sifre = "2326",
                OgrenciNo = "202201",
                mail = "mtumsek22@posta.pau.edu.tr",
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
                mail = "syilmaz23@posta.pau.edu.tr",
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
                AdSoyad = "Aslı Atalar",
                KullaniciAdi = "aatalar23",
                sinif = "2",
                Sifre = "2307",
                OgrenciNo = "202302",
                mail = "aatalar23@posta.pau.edu.tr",
                AlinanDersler = new List<Ders>
            {
                new Ders { DersAdi = "Turizm Politikası", Not = 0 },
                new Ders { DersAdi = "Turizm Mevzuatı", Not = 0 },
                new Ders { DersAdi = "Professional English", Not = 0 },
                new Ders { DersAdi = "Turizm Rehberliği", Not = 0 }
            }
            });

            Ogrenciler.Add(new Ogrenci
            {
                AdSoyad = "Berkay Özenel",
                KullaniciAdi = "bozenel21",
                sinif = "3",
                Sifre = "2310",
                OgrenciNo = "202101",
                mail = "bozenel21@posta.pau.edu.tr",
                AlinanDersler = new List<Ders>
            {
                new Ders { DersAdi = "Sistem Analizi", Not = 0 },
                new Ders { DersAdi = "Yazılım Mühendisliği", Not = 0 },
                new Ders { DersAdi = "Çıkarımsal İstatistik", Not = 0 },
                new Ders { DersAdi = "Kurumsal Kaynak Planlama", Not = 0 }
            }
            });

            Ogretmenler.Add(new Ogretmen
            {
                AdSoyad = "Ömer Güleç",
                KullaniciAdi = "ogulec",
                unvan = "Prof. Dr.",
                Sifre = "1111",
                telNo = "0 (258) 296 2807",
                mail = "omer@pau.edu.tr"
            });
        }



        private void anaMenu_Load(object sender, EventArgs e)
        {
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullanici = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            var ogr = Ogrenciler.FirstOrDefault(o => (o.KullaniciAdi == kullanici || o.mail == kullanici) && o.Sifre == sifre);
            if (ogr != null)
            {
                FormOgrenci frmOgrenci = new FormOgrenci(ogr);
                frmOgrenci.Show();
                //this.Hide();
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
                return;
                
            }

            var ogret = Ogretmenler.FirstOrDefault(o => (o.KullaniciAdi == kullanici || o.mail == kullanici) && o.Sifre == sifre);
            if (ogret != null)
            {
                FormOgretmen frmOgretmen = new FormOgretmen(ogret, Ogrenciler);
                frmOgretmen.Show();
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
                //this.Hide();
                return;
            }
            MessageBox.Show("Kullanıcı adı veya şifre yanlış, lütfen tekrar deneyiniz.","Hata");
            txtSifre.Clear();
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)  //sadece sayı girişi
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
