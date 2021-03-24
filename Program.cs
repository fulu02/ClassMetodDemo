using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriName = "Osman";
            musteri1.MusteriSurName = "Durmaz";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriName = "Ekrem";
            musteri2.MusteriSurName = "Solmaz";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriName = "Ahmet";
            musteri3.MusteriSurName = "Korkmaz";

            Musteri[] musteris = new Musteri[] { musteri1, musteri2, musteri3 };

            

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriAdd(musteri1);
            
            musteriManager.MusteriDelete(musteri2);
            musteriManager.MusteriList(musteri1,musteri2,musteri3);

        }
    }
}
