using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Hasan";
            musteri1.Soyadi = "Çifçi";
            musteri1.Aciklama = "Açıklama Eklendi";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ece Yaren";
            musteri2.Soyadi = "Taykutgül";
            musteri2.Aciklama = "Açıklama Eklendi";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Listele(musteri1);
            musteriManager.Sil(musteri1);
            musteriManager.Güncelle(musteri2);

        }
    }
}
