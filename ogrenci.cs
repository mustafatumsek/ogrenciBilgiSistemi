using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ogrenciBilgiSistemi
{

    public class Ogrenci : Kullanici
    {
        public string OgrenciNo { get; set; }

        public string sinif {  get; set; }
        public List<Ders> AlinanDersler { get; set; } = new List<Ders>();
    }
}
