// Nesneye dayalı programlama (OOP) kavramlarını gösteren basit bir C# programı.
// Bu program, sınıflar, nesneler, kalıtım, çok biçimlilik ve kapsülleme gibi temel OOP prensiplerini içerir.

using System; // Temel sistem fonksiyonları için
using System.IO; // Dosya işlemleri için
using System.Collections.Generic; // Generic koleksiyonlar için
using System.Linq; // LINQ işlemleri için


namespace OOP
{  // Namespace (Ad alanı)
    class program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci(); // Nesne (Object) oluşturma
            ogr1.OgrenciNo = 1; // Property (Özellik) atama
            ogr1.AdSoyad = "Ahmet Y"; // Property (Özellik) atama
            ogr1.Sube = "A"; // Property (Özellik) atama

            Ogrenci ogr2 = new Ogrenci(); // Nesne (Object) oluşturma
            ogr2.OgrenciNo = 2; // Property (Özellik) atama
            ogr2.AdSoyad = "Mehmet K"; // Property (Özellik) atama
            ogr2.Sube = "B"; // Property (Özellik) atama

            Ogrenci ogr3 = new Ogrenci() // Nesne (Object) oluşturma
            {
                OgrenciNo = 3, // Property (Özellik) atama
                AdSoyad = "Ayşe T", // Property (Özellik) atama
                Sube = "C" // Property (Özellik) atama
            };

            Ogrenci ogr4 = new Ogrenci() { OgrenciNo = 4, AdSoyad = "Fatma S", Sube = "D" };


            // Araba nesneleri
            Araba araba1 = new Araba("Toyota", "Corolla", 2020);
            Araba araba2 = new Araba("Renault", "Clio", 2018);

            //Ogrenci[] ogrenciler = new Ogrenci[4]; // 3 elemanlı boş bir dizi tanımladık

            //ogrenciler[0] = ogr1;
            //ogrenciler[1] = ogr2;
            //ogrenciler[2] = ogr3;
            //ogrenciler[3] = ogr4;

            Ogrenci[] ogrenciler = { ogr1, ogr2, ogr3, ogr4 }; // Diziyi tanımlarken elemanlarıyla birlikte de tanımlayabiliriz

            foreach (var ogrenci in ogrenciler) // Dizinin her bir elemanı için döner
            {
                ogrenci.BilgileriGoster(); // Metot çağırma
            }

            //foreach (var ogrenci in ogrenciler) // Dizinin her bir elemanı için döner
            //{
            //    Console.WriteLine($"{ogrenci.OgrenciNo} numaralı öğrencinin adı {ogrenci.AdSoyad} ve şubesi {ogrenci.Sube}");
            //}


            //Console.WriteLine($"{ogr1.OgrenciNo} numaralı öğrencinin adı {ogr1.AdSoyad} ve şubesi {ogr1.Sube}");
            //Console.WriteLine($"{ogr2.OgrenciNo} numaralı öğrencinin adı {ogr2.AdSoyad} ve şubesi {ogr2.Sube}");
            //Console.WriteLine($"{ogr3.OgrenciNo} numaralı öğrencinin adı {ogr3.AdSoyad} ve şubesi {ogr3.Sube}");

            Console.WriteLine("----------------------------------------------");

            // Araba bilgileri
            araba1.BilgileriYazdir();
            araba2.BilgileriYazdir();

            // Static metot örneği
            Araba.KacTekerlekli();

        }

    }

    class Ogrenci
    {
        public Ogrenci(int gizli) // Constructor (Yapıcı metot)
                         // Sınıftan bir nesne oluşturulduğunda çalışan metot
                         // Genellikle nesneye başlangıç değeri atamak için kullanılır
                         // Örneğin, rastgele bir ID atamak için kullanılabilir
        {
            this.RandomId = (new Random()).Next(1000, 9999); // 1000 ile 9999 arasında rastgele bir sayı atar
            
            this.gizli = gizli; // Parametreyi private property'e atar
            
        
        }

        // Property (Özellik)
        public int OgrenciNo { get; set; }
        public string AdSoyad { get; set; }
        public string Sube { get; set; }
        public int RandomId { get; set; }

        private int gizli { get; set; }

        // Method (Metot)
        public string BilgileriGoster()
        {
            return $"{this.OgrenciNo} numaralı öğrencinin adı {this.AdSoyad} ve şubesi {this.Sube}"; // this: o anki nesneyi temsil eder.
        }
    }


    class Araba
    {
        private string motorNo;
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }

        public Araba(string marka, string model, int yil)
        {
            Marka = marka;
            Model = model;
            Yil = yil;
            motorNo = Guid.NewGuid().ToString();
        }

        public void BilgileriYazdir()
        {
            Console.WriteLine($"Marka: {Marka}, Model: {Model}, Yıl: {Yil}");
        }

        public static void KacTekerlekli()
        {
            Console.WriteLine("Arabalar genellikle 4 tekerleklidir.");
        }
    }
}