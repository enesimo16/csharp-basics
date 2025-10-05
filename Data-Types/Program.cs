// VVERİ TİPLERİ
// Değer tipleri:

// Tam sayılar: int, long, short, byte
// onaltılı sayılar: float, double, decimal
// diğer: bool, char, struct, enum

// Referans tipleri:

// string, array, class, interface,

int sayi = 200;
decimal fiyat = 99.99m; // decimal türü için 'm' eklenir
double oran = 0.75; // d türü için 'd' eklenir, eklenmesi zorunlu değildir
bool aktif = true;
char karakter = 'A';
string mesaj = "Merhaba, Dünya!";
int[] sayilar = { 1, 2, 3, 4, 5 };
float pi = 3.14f; // float türü için 'f' eklenir

// VERİ TİPİ DEĞİŞTİRME

// Implicit Conversion (Bilinçsiz Dönüşüm) - Küçük veri tipinden büyük veri tipine dönüşüm
// Explicit Conversion (Bilinçli Dönüşüm) - Büyük veri tipinden küçük veri tipine dönüşüm
// Parse ve Convert - string türünden diğer veri tiplerine dönüşüm
// Nullable Types - null değeri alabilen veri tipleri
// var - Derleyicinin türü otomatik olarak belirlemesi
// object - Tüm veri tiplerinin üst tipi
// Dynamic - Türü çalışma zamanında belirlenen veri tipi


Console.Write("Bir sayı girin: ");
var sayi1 = Console.ReadLine();

Console.Write("Bir sayı daha girin: ");
var sayi2 = Console.ReadLine();

var toplam = sayi1 + sayi2; // string birleştirme, çünkü sayi1 ve sayi2 string türünde fakat yanlış kullanım çünkü string toplama yapar. 1020 = enesyel gibiç.
Console.WriteLine("Toplam (string birleştirme): " + toplam);

// Doğru kullanım - int türüne dönüştürme

int sayi1Int = int.Parse(sayi1); // veya Convert.ToInt32(sayi1);
int sayi2Int = int.Parse(sayi2); // veya Convert.ToInt32(sayi2);

var dogruToplam = sayi1Int + sayi2Int;
Console.WriteLine("Toplam (doğru): " + dogruToplam);


int? maas = null; // Nullable int türü
int? prim = 500; // Nullable int türü

Console.WriteLine(maas.HasValue); // false
Console.WriteLine(prim.HasValue); // true




