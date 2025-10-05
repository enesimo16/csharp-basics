// STRİNG 

string ad = "Enes";
string soyad = "Yılmaz";
string yas = "30";

string bilgi = $"Benim adım {ad} {soyad} ve ben {yas} yaşındayım."; // String Interpolation
string bilgi2 = ad + " " + soyad + " ve ben " + yas + " yaşındayım."; // String Concatenation

Console.WriteLine(bilgi);
Console.WriteLine(bilgi2);

Console.Write("Firma ismi: ");
var firma = Console.ReadLine();

Console.Write("Firma adresi: ");
var adres = Console.ReadLine();

string firmaBilgi = $"Firma ismi: {firma}, Firma adresi: {adres}"; // $ işareti String Interpolation için kullanılır.
Console.WriteLine(firmaBilgi);

// String Methods
// string metodları için https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0 adresini ziyaret edebilirsiniz.
// ToUpper, ToLower, Trim, Replace, Substring, Split, IndexOf, LastIndexOf, StartsWith, EndsWith, Contains

// Trim: baştaki ve sondaki boşlukları siler.
// Replace: belirli bir karakteri değiştirir.
// Substring: belirli bir kısmını alır.
// Split: belirli bir karaktere göre parçalar.
// IndexOf: belirli bir karakterin indexini verir.
// StartsWith: belirli bir karakterle başlıyor mu?
// EndsWith: belirli bir karakterle bitiyor mu?
// Contains: belirli bir karakteri içeriyor mu?

string mesaj = "   Merhaba Dünya! Bugün hava çok güzel.   ";
Console.WriteLine(mesaj.Length); // 44
Console.WriteLine(mesaj.Trim().Length); // 40
Console.WriteLine(mesaj.ToUpper()); // MERHABA DÜNYA! BUGÜN HAVA ÇOK GÜZEL.
Console.WriteLine(mesaj.ToLower()); // merhaba dünya! bugün hava çok güzel.
Console.WriteLine(mesaj.Replace("Dünya", "Evren")); // Merhaba Evren! Bugün hava çok güzel.
Console.WriteLine(mesaj.Substring(3, 7)); // haba Dü
string[] kelimeler = mesaj.Split(' '); // boşluk karakterine göre parçala
Console.WriteLine(kelimeler[2]); // Dünya!
Console.WriteLine(mesaj.IndexOf("hava")); // 20
Console.WriteLine(mesaj.LastIndexOf("a")); // 37
Console.WriteLine(mesaj.StartsWith("   Merhaba")); // True
Console.WriteLine(mesaj.EndsWith("güzel.   ")); // True
Console.WriteLine(mesaj.Contains("hava")); // True
Console.WriteLine(mesaj.Contains("yağmur")); // False
Console.WriteLine(mesaj.Contains("HAVA")); // False - Büyük küçük harf duyarlılığı var
Console.WriteLine(mesaj.ToLower().Contains("hava")); // True - Büyük küçük harf duyarlılığı yok


// DATETIME
// DateTime yapısı için https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-8.0 adresini ziyaret edebilirsiniz.

DateTime now = DateTime.Now; // Şu anki tarih ve saat
DateTime today = DateTime.Today; // Bugünün tarihi (saat 00:00:00)
DateTime specificDate = new DateTime(2024, 6, 1); // Belirli bir tarih (1 Haziran 2024)
DateTime specificDateTime = new DateTime(2024, 6, 1, 14, 30, 0); // Belirli bir tarih ve saat (1 Haziran 2024, 14:30:00)
Console.WriteLine(now); // 05.10.2025 13:10:45
Console.WriteLine(today); // 05.10.2025 00:00:00
Console.WriteLine(specificDate); // 01.06.2024 00:00:00
Console.WriteLine(specificDateTime); // 01.06.2024 14:30:00
Console.WriteLine(now.Year); // 2025
Console.WriteLine(now.Month); // 10
Console.WriteLine(now.Day); // 5
Console.WriteLine(now.Hour); // 13.10

DateTime dt = new DateTime(2224, 6, 1, 14, 30, 0);
Console.WriteLine(dt);
DateTime dt2 = dt.AddYears(10); // 10 gün ekle
Console.WriteLine(dt2);
