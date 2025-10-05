using System;


class exceptionHandling
{
    static void Main(string[] args)
    {

        // Try-Catch-Finally blokları ile hata yönetimi

        try // Hata olabilecek kod bloğu
        {
            Console.Write("Bir sayı girin: ");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine($"Girdiğiniz sayı: {sayi}");
        }
        catch (FormatException ex) // Belirli bir hata türünü yakalar
        {
            Console.WriteLine("Hata: Geçersiz format. Lütfen bir sayı girin.");
            Console.WriteLine($"Detaylar: {ex.Message}"); // Hata mesajını gösterir
        }
        catch (OverflowException ex) // Sayı çok büyük veya çok küçük olduğunda oluşan hata
        {
            Console.WriteLine("Hata: Sayı çok büyük veya çok küçük.");
            Console.WriteLine($"Detaylar: {ex.Message}");
        }
        catch (Exception ex) // Diğer tüm hataları yakalar
        {
            Console.WriteLine("Hata: Beklenmeyen bir hata oluştu.");
            Console.WriteLine($"Detaylar: {ex.Message}");
        }
        finally // Hata olsun veya olmasın her zaman çalışır
        {
            Console.WriteLine("Program sonlandı.");
        }


        // Throw anahtar kelimesi ile özel hata fırlatma

        int sayi = 10;

        if (sayi < 0)
        {
            throw new ArgumentOutOfRangeException("sayi", "Sayı negatif olamaz."); // Özel bir hata fırlatır
        }

        // debugging

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
            System.Diagnostics.Debug.WriteLine($"Debug: i değeri {i}"); // Debug penceresine bilgi yazdırır

        }

    }
}