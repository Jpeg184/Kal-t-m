using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
   public class Temel
    {
        public int Id { get; set; } 
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Adres Adres { get; set; }
        public DateTime DogumTarih { get; set; }
        public char Cins { get; set; }

        //public char cins;
        //public char Cins
        //{
        //    get
        //    {
        //        return cins;
        //    }
        //    set
        //    {
        //        if (value=='E')
        //        {
        //          cins = 'E'; 
        //        }
        //        else
        //        {
        //            cins = 'K';
        //        }

        //    }
    //}
        

        public Temel()
        {
            Adres = new Adres();
        }

        public string GetTitle()
        {
            if (Cins == 'E')
            {
                return $"Sayın Bey {Ad} {Soyad}";
            }
            else
            {
                return $"Sayın Bayan {Ad} {Soyad}";
            }
        }
        public List<string> GetAdres()
        {
            List<string> adres = new List<string>();
            adres.Add(Adres.Cadde);
            adres.Add(Adres.Sokak);
            adres.Add(Adres.Kapino.ToString());
            adres.Add($"{Adres.Ilce}/{Adres.Sehir}");
            return adres;
        }
        public int GetAge()
        {
            DateTime today = DateTime.Now;
            int yas = today.Year - DogumTarih.Year;
            DateTime DogumGunu = DogumTarih.AddYears(yas);
            if (DogumGunu < today)
            {
                yas = yas + 1;
            }
            return yas;
        }

    }
}
