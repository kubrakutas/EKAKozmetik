using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKAKozmetik.Model
{
    public class Siparis
    {
        public int ID { get; set; }
        public string UrunIsim { get; set; }
        public double ToplamFiyat { get; set; }
        public int Adet { get; set; }
        public DateTime Tarih { get; set; }
        public string KargoDurumu { get; set; }
    }
}
