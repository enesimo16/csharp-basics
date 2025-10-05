// Collections // Koleksiyonlar
// using System; // Temel sistem fonksiyonları için
// using System.Collections; // Non-generic koleksiyonlar için
// using System.Collections.Generic; // Generic koleksiyonlar için

using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // non -generic koleksiyonlar. non-generic => object türünde çalışır.
            // ArrayList, farklı türdeki verileri bir arada tutabilir.
            // Ancak, tür güvenliği sağlamaz ve performans açısından dezavantajlıdır.

            ArrayList liste = new ArrayList();
            liste.Add(1); // int
            liste.Add("İki"); // string
            liste.Add(3.0); // double
            liste.Add(true); // bool
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            var liste2 = new ArrayList() { 1, "İki", 3.0, true };

            liste.AddRange(liste2); // liste2'yi liste'ye ekler.
            Console.WriteLine("-----");
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----");
            liste.Remove(3.0); // 3.0 değerini listeden siler.
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----");
            liste.RemoveAt(0); // 0. indeksteki değeri siler.
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----");
            liste.Insert(0, "Sıfır"); // 0. indekse "Sıfır" değerini ekler.
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----");
            Console.WriteLine(liste.Contains("İki")); // liste'de "İki" değeri var mı? true döner.
            Console.WriteLine(liste.Count); // liste'deki eleman sayısını döner.
            liste.Clear(); // liste'yi temizler.
            Console.WriteLine(liste.Count); // liste'deki eleman sayısını döner.
            Console.WriteLine("-----");
           

            // generic koleksiyonlar.
            // List<T>, sadece belirli bir türdeki verileri tutar.
            // Tür güvenliği sağlar ve performans açısından daha iyidir.

            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----");
            List<string> isimler = new List<string>() { "Ali", "Ayşe", "Fatma" };
            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----");
            isimler.AddRange(new string[] { "Mehmet", "Ahmet" }); // yeni bir string dizisi ekler.
            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----");
            isimler.Remove("Ayşe"); // "Ayşe" değerini listeden siler.
            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----");
            isimler.RemoveAt(0); // 0. indeksteki değeri siler.
            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----");
            isimler.Insert(0, "Zeynep"); // 0. indekse "Zeynep" değerini ekler.

            // dictionary
            // anahtar-değer çiftleri şeklinde veri tutar.
            // anahtarlar benzersiz olmalıdır.
            // hızlı arama ve erişim sağlar.

            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(1, "Ali");
            kullanicilar.Add(2, "Ayşe");
            kullanicilar.Add(3, "Fatma");
            foreach (var item in kullanicilar)
            {
                Console.WriteLine($"Anahtar: {item.Key}, Değer: {item.Value}");
            }
            Console.WriteLine("-----");
            Console.WriteLine(kullanicilar[2]); // 2 anahtarına karşılık gelen değeri döner.
            kullanicilar[2] = "Mehmet"; // 2 anahtarına karşılık gelen değeri değiştirir.
            foreach (var item in kullanicilar)
            {
                Console.WriteLine($"Anahtar: {item.Key}, Değer: {item.Value}");
            }
            Console.WriteLine("-----");
            kullanicilar.Remove(1); // 1 anahtarını ve değerini siler.
            foreach (var item in kullanicilar)
            {
                Console.WriteLine($"Anahtar: {item.Key}, Değer: {item.Value}");
            }
            Console.WriteLine("-----");
            Console.WriteLine(kullanicilar.ContainsKey(3)); // 3 anahtarı var mı? true döner.
            Console.WriteLine(kullanicilar.Count); // kullanicilar'daki eleman sayısını döner.
            kullanicilar.Clear(); // kullanicilar'ı temizler.
            Console.WriteLine(kullanicilar.Count); // kullanicilar'daki eleman sayısını döner.
            Console.WriteLine("-----");


        }
    }

}