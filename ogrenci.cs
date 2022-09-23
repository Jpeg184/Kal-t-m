using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım 
{
    public class ogrenci : Temel
    {
        public string Bolum { get; set; } 
        
        public DateTime KayitTarihi { get; set; }

        public ogrenci ()
        {
            KayitTarihi = DateTime.Now; 
        }

    }
}
