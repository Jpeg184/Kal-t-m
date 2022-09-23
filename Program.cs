namespace Kalıtım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ogrenci o = new ogrenci();
            o.Ad = "İpek";
            o.Soyad = "Yılmaz";
            o.Bolum = "Bilişim Yönetim Sistemleri";
            o.Cins = 'K';
            o.Id = 1; //ilk kayıt olan öğrenci
            o.DogumTarih = Convert.ToDateTime("26/03/1997");
            o.Adres.Cadde = "Ayvansaray Caddesi";
            o.Adres.Ilce = "Kadıköy";
            o.Adres.Sehir = "İstanbul";
            o.Adres.Sokak = "Balat Sokak";
            o.Adres.Kapino = 7;
            Console.WriteLine(o.GetTitle());    
            foreach(var item in o.GetAdres())
            {
                Console.WriteLine(item);    
            }
            Console.WriteLine(o.GetAge());
            Console.WriteLine(o.KayitTarihi);
        }
    }
}