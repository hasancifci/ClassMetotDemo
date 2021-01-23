using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi " + musteri.Adi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi " + musteri.Adi);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Musteri Listelendi " + musteri.Adi);
        }
        public void Güncelle(Musteri musteri)
        {
            Console.WriteLine("Musteri Güncellendi " + musteri.Adi);
        }

    }
}
