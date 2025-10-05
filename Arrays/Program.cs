// DİZİLER

string[] isimler = new string[2]; // 2 elemanlı boş bir dizi tanımladık
isimler[0] = "Ahmet"; // Dizinin 0. indeksine "Ahmet" değerini atadık
isimler[1] = "Mehmet"; // Dizinin 1. indeksine "Mehmet" değerini atadık

Console.WriteLine(isimler[0]); // Dizinin 0. indeksindeki değeri ekrana yazdırır
Console.WriteLine(isimler[1]); // Dizinin 1. indeksindeki değeri ekrana yazdırır
Console.WriteLine(isimler.Length); // Dizinin uzunluğunu ekrana yazdırır (2)
Console.WriteLine("--------------");
// Diziyi tanımlarken elemanlarıyla birlikte de tanımlayabiliriz
string[] sehirler = { "Ankara", "İstanbul", "İzmir" }; // 3 elemanlı bir dizi tanımladık
Console.WriteLine(sehirler[0]); // Dizinin 0. indeksindeki değeri ekrana yazdırır
Console.WriteLine(sehirler[1]); // Dizinin 1. indeksindeki değeri ekrana yazdırır
Console.WriteLine(sehirler[2]); // Dizinin 2. indeksindeki değeri ekrana yazdırır
Console.WriteLine(sehirler.Length); // Dizinin uzunluğunu ekrana yazdırır (3)

Console.WriteLine("--------------");

// Array metodlarını kullanabiliriz
// SetValue: Dizinin belirli bir indeksine değer atar
// GetValue: Dizinin belirli bir indeksindeki değeri alır
// Length: Dizinin uzunluğunu verir

sehirler.SetValue("sakarya", 0); // Dizinin 0. indeksine "Sakarya" değerini atadık, değiştirdik.
Console.WriteLine(sehirler.GetValue(1)); // Dizinin 1. indeksindeki değeri ekrana yazdırır
Console.WriteLine(sehirler.Length); // Dizinin uzunluğunu ekrana yazdırır (3)

Array.Sort(sehirler); // Diziyi alfabetik olarak sıralar.
Array.Reverse(sehirler); // Diziyi tersine çevirir.
Array.Clear(sehirler, 0, 1); // Dizinin 0. indeksinden başlayarak 1 elemanı temizler (null yapar).

Console.WriteLine("--------------");

// Array Slicing
// C# 8.0 ile gelen bir özellik, dizinin belirli bir kısmını almayı sağlar

string[] yeniSehirler = sehirler[0..2]; // Dizinin 0. indeksinden başlayarak 2 eleman alır
Console.WriteLine(yeniSehirler.Length); // Yeni dizinin uzunluğunu ekrana yazdırır (2)
Console.WriteLine(yeniSehirler[0]); // Yeni dizinin 0. indeksindeki değeri ekrana yazdırır
Console.WriteLine("--------------");

// Çok boyutlu diziler
int[,] matris = new int[2, 3]; // 2 satır ve 3 sütundan oluşan boş bir matris tanımladık
matris[0, 0] = 1; // Matrisin 0. satır ve 0. sütununa 1 değerini atadık
matris[0, 1] = 2; // Matrisin 0. satır ve 1. sütununa 2 değerini atadık
matris[0, 2] = 3; // Matrisin 0. satır ve 2. sütununa 3 değerini atadık
matris[1, 0] = 4; // Matrisin 1. satır ve 0. sütununa 4 değerini atadık
matris[1, 1] = 5; // Matrisin 1. satır ve 1. sütununa 5 değerini atadık
matris[1, 2] = 6; // Matrisin 1. satır ve 2. sütununa 6 değerini atadık
Console.WriteLine(matris[0, 0]); // Matrisin 0. satır ve 0. sütunundaki değeri ekrana yazdırır
Console.WriteLine(matris[1, 2]); // Matrisin 1. satır ve 2. sütunundaki değeri ekrana yazdırır
Console.WriteLine(matris.Length); // Matrisin toplam eleman sayısını ekrana yazdırır (6)
Console.WriteLine("--------------");

// Reference type (referans tip) olan diziler, heap bellekte saklanır ve stack bellekteki referans ile erişilir
// Değer tip (value type) olan int, char, bool gibi tipler ise stack bellekte saklanır
// Bu nedenle diziler büyük veri yapıları için daha uygundur
// Çünkü heap bellekte daha büyük veri saklanabilir
// Ayrıca diziler üzerinde yapılan işlemler (ekleme, silme, güncelleme) daha hızlıdır
// Çünkü diziler referans tip olduğu için bellekteki adresi üzerinden işlem yapılır
// Değer tiplerde ise her seferinde kopyalama işlemi yapılır
// Bu da performans kaybına neden olabilir

int x = 10;
int y = x; // y, x'in değerini kopyalar (değer tipi)
Console.WriteLine(x); // 10
Console.WriteLine(y); // 10
x = 20; // x'in değerini değiştirir, y etkilenmez.
Console.WriteLine(x); // 20
Console.WriteLine(y); // 10

string[] dizi1 = { "A", "B", "C" };
string[] dizi2 = dizi1; // dizi2, dizi1'in referansını kopyalar (referans tipi)
Console.WriteLine(dizi1[0]); // A
Console.WriteLine(dizi2[0]); // A
dizi1[0] = "Z"; // dizi1'in 0. indeksindeki değeri değiştirir, dizi2 de etkilenir.
Console.WriteLine(dizi1[0]); // Z
Console.WriteLine(dizi2[0]); // Z








// Dizilerde döngü kullanarak tüm elemanları ekrana yazdırabiliriz
for (int i = 0; i < sehirler.Length; i++)
{
    Console.WriteLine(sehirler[i]); // Dizinin i. indeksindeki değeri ekrana yazdırır
}
Console.WriteLine("--------------");
// foreach döngüsü ile dizinin tüm elemanlarını ekrana yazdırabiliriz
foreach (var sehir in sehirler)
{
    Console.WriteLine(sehir); // Dizinin her bir elemanını ekrana yazdırır
}
Console.WriteLine("--------------");


