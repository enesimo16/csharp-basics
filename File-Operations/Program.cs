// Dosya İşlemleri

// StreamReader sr = File.OpenText("example.txt"); // Dosyayı açar

//var s = "";

//while ((s = sr.ReadLine()) != null) // Satır satır okur
//{
//    Console.WriteLine(s); // Satırı ekrana yazdırır
//}

// File.ReadAllText("example.txt"); // Dosyanın tamamını okur


StreamWriter sw=File.CreateText("example2.txt"); // Yeni bir dosya oluşturur

sw.WriteLine("Merhaba Dünya!"); // Dosyaya satır yazar

sw.Close(); // Dosyayı kapatır

File.ReadAllText("example2.txt"); // Dosyanın tamamını okur

// Dosya işlemleri
File.Copy("example2.txt", "example3.txt"); // Dosyayı kopyalar
File.Delete("example3.txt"); // Dosyayı siler
var dosyaVarMi = File.Exists("example2.txt"); // Dosyanın var olup olmadığını kontrol eder
var dosyaYolu = Path.Combine("C:", "Klasor", "example2.txt"); // Dosya yolunu birleştirir
var dosyaAdi = Path.GetFileName(dosyaYolu); // Dosya adını alır
var dosyaUzantisi = Path.GetExtension(dosyaYolu); // Dosya uzantısını alır

// Klasör işlemleri

Directory.CreateDirectory("yeniKlasor"); // Yeni bir klasör oluşturur
Directory.Delete("yeniKlasor"); // Klasörü siler
var klasorler = Directory.GetDirectories("."); // Mevcut dizindeki klasörleri alır
var dosyalar = Directory.GetFiles("."); // Mevcut dizindeki dosyaları alır
var klasorBilgisi = new DirectoryInfo("."); // Mevcut dizinin bilgilerini alır
var dosyaBilgisi = new FileInfo("example2.txt"); // Dosyanın bilgilerini alır
Console.WriteLine(klasorBilgisi.CreationTime); // Klasörün oluşturulma tarihini ekrana yazdırır
Console.WriteLine(dosyaBilgisi.Length); // Dosyanın boyutunu ekrana yazdırır (byte cinsinden)
   

