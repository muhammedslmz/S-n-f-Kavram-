using System;
namespace sinif_kavrami
{
    class program
    {
        static void Main(string []args)
        {
            çalışan user1 =new çalışan();
            çalışan user2=new çalışan();
            user1.ad="Muhammed";
            user1.soyad="Solmaz";
            user1.no=25887915;
            user1.departman="IT";
        
            user2.ad="İkbal";
            user2.soyad="Kıyatsıl";
            user2.no=15996315;
            user2.departman="Muhasebe";

            user1.çalışanBilgileriYazdırma();
            Console.WriteLine("*********************");
            user2.çalışanBilgileriYazdırma();
        }
    }    
    class çalışan
    {
        public string ad;
        public string soyad;
        public int no;
        public string departman;
        public void çalışanBilgileriYazdırma()
        {
            Console.WriteLine("Çalışanın adı: "+ ad);
            Console.WriteLine("Çalışanın soyadı: "+soyad);
            Console.WriteLine("Çalışanın numarası: "+no);
            Console.WriteLine("Çalışanın departmanı: "+departman);
        }
    }
}