using System;

namespace SinifKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Erişim Berlirleyiciler
            
            // public 
            // private
            // Internal
            // Protected

            Calisan calisan1 = new Calisan();
            calisan1.ad = "Burak";
            calisan1.soyad = "Layık";
            calisan1.departman = "Muhasebe";
            calisan1.no = 75869;

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.ad = "Meryem";
            calisan2.soyad = "Layık";
            calisan2.departman = "Pazarlama";
            calisan2.no = 46493;

            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string ad;
        public string soyad;
        public string departman;
        public int no;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı : " + ad);
            Console.WriteLine("Çalışan Soyadı : " + soyad);
            Console.WriteLine("Çalışan Departmanı : " + departman);
            Console.WriteLine("Çalışan Numarası : " + no);
        }
    }
}
