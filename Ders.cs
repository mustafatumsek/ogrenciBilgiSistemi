using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciBilgiSistemi
{
    public class Ders
    {
        public string DersAdi { get; set; }
        public int Not { get; set; }

        public string Durum
        {
            get
            {
                return Not >= 50 ? "Geçti" : "Kaldı";
            }
        }
    }

}
