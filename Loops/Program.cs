// Döngüler

// For döngüsü
// Belirli bir sayıda tekrarlanması gereken işlemler için kullanılır

for (int i = 0; i < 10; i++) // i 0'dan başlayarak 10'dan küçük olduğu sürece 1'er 1'er artacak
{
    Console.WriteLine(i); // i'nin o anki değerini ekrana yazdırır
}


var toplam = 0;
for (var i = 0; i < 100; i++)
{
    toplam += i; // toplam = toplam + i
}
Console.WriteLine("0'dan 100'e kadar olan sayıların toplamı: " + toplam);


Console.Write("Başlangıç değeri: ");
var baslangic = int.Parse(Console.ReadLine());
Console.Write("Bitiş değeri: ");
var bitis = int.Parse(Console.ReadLine()); // convert.ToInt32 da kullanılabilir

var toplam2 = 0;
for (var i = baslangic; i <= bitis; i++)
{
    toplam2 += i;
}
Console.WriteLine($"{baslangic} ile {bitis} arasındaki sayıların toplamı: {toplam2}");


string [] meyveler = { "Elma", "Armut", "Muz", "Çilek" };

for (var i = 0; i < meyveler.Length; i++) // meyveler dizisinin uzunluğu kadar döner
{
    Console.WriteLine(meyveler[i]); // meyveler dizisinin i. indeksindeki değeri ekrana yazdırır
}



int[] sayilar = { 1, 2, 3, 4, 5 , 7 , 8 , 9 , 10};

for (var i = 0; i < sayilar.Length; i++)
{
    if (sayilar[i] % 3 == 0)
    {
        Console.WriteLine(sayilar[i]);
    }

}


// While döngüsü
// Belirli bir koşul sağlandığı sürece tekrarlanması gereken işlemler için kullanılır

while (true) // Sonsuz döngü
{
    Console.Write("Bir sayı girin (Çıkmak için q): ");
    var input = Console.ReadLine();
    if (input.ToLower() == "q") // Küçük harfe çevirip q'ya eşit mi diye kontrol eder
    {
        break; // Döngüyü sonlandırır
    }
    var sayi = int.Parse(input); // Girilen değeri int'e çevirir
    Console.WriteLine("Girdiğiniz sayının karesi: " + (sayi * sayi));
}

string[] renkler = { "Kırmızı", "Yeşil", "Mavi", "Sarı" };

var i = 0;
while (i < renkler.Length)
{
    Console.WriteLine(renkler[i]);
    i++;
}


var secim = "e";
var sayac = 1;
var toplam3 = 0;

while(secim.ToLower() == "e") // Küçük harfe çevirip e'ye eşit mi diye kontrol eder
{
    Console.Write($"Lütfen {sayac}. sayıyı girin: ");
    var sayi = int.Parse(Console.ReadLine());
    toplam3 += sayi; // toplam3 = toplam3 + sayi
    sayac++;
    Console.Write("Devam etmek istiyor musunuz? (e/h): ");
    secim = Console.ReadLine();
}

// Break ve Continue
// Break: Döngüyü tamamen sonlandırır
// Continue: O anki döngü adımını atlar, bir sonraki adıma geçer

for (var j = 1; j <= 10; j++)
{
    if (j == 5)
    {
        break; // j 5 olduğunda döngüyü sonlandırır
    }
    Console.WriteLine(j); // 1'den 4'e kadar olan sayıları ekrana yazdırır
}

for (var j = 1; j <= 10; j++)
{
    if (j % 2 == 0)
    {
        continue; // j çift sayı olduğunda o adımı atlar
    }
    Console.WriteLine(j); // Sadece tek sayıları ekrana yazdırır
}


var rnd = new Random();
int tutulanSayi = rnd.Next(1, 101); // 1 ile 100 arasında rastgele bir sayı tutar
int hak = 5; // Kullanıcının 5 hakkı var

while (hak > 0)
{
    Console.Write("Tahmininizi girin (1-100): ");
    int tahmin = int.Parse(Console.ReadLine());
    if (tahmin == tutulanSayi)
    {
        Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
        break; // Doğru tahmin edildiğinde döngüyü sonlandırır
    }
    else if (tahmin < tutulanSayi)
    {
        Console.WriteLine("Daha yüksek bir sayı deneyin.");
    }
    else
    {
        Console.WriteLine("Daha düşük bir sayı deneyin.");
    }
    hak--; // Hakkı bir azaltır
    Console.WriteLine($"Kalan hakkınız: {hak}");
    if (hak == 0)
    {
        Console.WriteLine($"Hakkınız bitti! Tutulan sayı: {tutulanSayi}");
    }
}


// do-while döngüsü
// Koşul sağlanmasa bile en az bir kez çalışması gereken işlemler için kullanılır

do // En az bir kez çalışır
{
    Console.Write("Bir sayı girin (Çıkmak için q): ");
    var input = Console.ReadLine();
    if (input.ToLower() == "q") // Küçük harfe çevirip q'ya eşit mi diye kontrol eder
    {
        break; // Döngüyü sonlandırır
    }
    var sayi = int.Parse(input); // Girilen değeri int'e çevirir
    Console.WriteLine("Girdiğiniz sayının karesi: " + (sayi * sayi));
} while (true); // Sonsuz döngü

Console.Write("Adet: ");
int adet = int.Parse(Console.ReadLine());

string[] urunler = new string[adet];

int i = 0;

do
{
    Console.Write("Ürün adı: ");
    urunler[i] = Console.ReadLine();

    i++;
} while (adet != i);

Console.WriteLine("Eklenen ürünler:");


// foreach döngüsü
// Diziler ve koleksiyonlar üzerinde tek tek dolaşmak için kullanılır

foreach (var meyve in meyveler) // meyveler dizisinin her bir elemanı için döner
{
    Console.WriteLine(meyve); // o anki meyve değerini ekrana yazdırır
}






