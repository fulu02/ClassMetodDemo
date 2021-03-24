using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager
    {
        public void Add (Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriName + " " + musteri.MusteriSurName + " " + "Eklendi.");

        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriName + " " + musteri.MusteriSurName + " " + "Silindi.");

        }
        public void GetAll (Musteri[] Musteriler)

        {
            foreach (var musteri in Musteriler)
            {
                Console.WriteLine(musteri.MusteriName + " " + musteri.MusteriSurName + "Müşteri eklenmiştir.");
            }

            
        }

        internal void MusteriDelete(Musteri musteri2)
        {
            throw new NotImplementedException();
        }

        internal void MusteriAdd(Musteri musteri1)
        {
            throw new NotImplementedException();
        }

        internal void MusteriList(Musteri musteri1, Musteri musteri2, Musteri musteri3)
        {
            throw new NotImplementedException();
        }
    }
}
