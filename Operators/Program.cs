// Operatörler
// C# dilinde operatörler, değişkenler ve sabitler üzerinde işlemler gerçekleştirmek için kullanılır.
// Operatörler, matematiksel işlemler, karşılaştırmalar, mantıksal işlemler ve daha fazlasını yapmamızı sağlar.
// Operatörler, tek bir karakter veya birden fazla karakterden oluşabilir.
// Örneğin, + operatörü toplama işlemi için kullanılırken, && operatörü mantıksal VE işlemi için kullanılır.

using System;

class Program
{
    static void Main()
    {
        // 1. Aritmetik Operatörler
        int a = 10, b = 3;
        Console.WriteLine("Aritmetik Operatörler:");
        Console.WriteLine($"a + b = {a + b}"); // Toplama
        Console.WriteLine($"a - b = {a - b}"); // Çıkarma
        Console.WriteLine($"a * b = {a * b}"); // Çarpma
        Console.WriteLine($"a / b = {a / b}"); // Bölme (tam sayı bölmesi)
        Console.WriteLine($"a % b = {a % b}"); // Mod (kalan)

        // 2. Atama Operatörleri
        int c = 5;
        Console.WriteLine("\nAtama Operatörleri:");
        c += 2; // c = c + 2
        Console.WriteLine($"c += 2 -> {c}");
        c *= 3; // c = c * 3
        Console.WriteLine($"c *= 3 -> {c}");

        // 3. Karşılaştırma Operatörleri
        Console.WriteLine("\nKarşılaştırma Operatörleri:");
        Console.WriteLine($"a == b : {a == b}"); // Eşit mi?
        Console.WriteLine($"a != b : {a != b}"); // Eşit değil mi?
        Console.WriteLine($"a > b  : {a > b}");  // Büyük mü?
        Console.WriteLine($"a < b  : {a < b}");  // Küçük mü?
        Console.WriteLine($"a >= b : {a >= b}"); // Büyük veya eşit mi?
        Console.WriteLine($"a <= b : {a <= b}"); // Küçük veya eşit mi?

        // 4. Mantıksal Operatörler
        bool x = true, y = false;
        Console.WriteLine("\nMantıksal Operatörler:");
        Console.WriteLine($"x && y : {x && y}"); // VE (and)
        Console.WriteLine($"x || y : {x || y}"); // VEYA (or)
        Console.WriteLine($"!x     : {!x}");     // DEĞİL (not)

        // 5. Artırma/Azaltma Operatörleri
        int d = 7;
        Console.WriteLine("\nArtırma/Azaltma Operatörleri:");
        d++;
        Console.WriteLine($"d++ -> {d}"); // Önce değeri kullanır, sonra 1 artırır
        d--;
        Console.WriteLine($"d-- -> {d}"); // Önce değeri kullanır, sonra 1 azaltır

        // 6. Koşul (Ternary) Operatörü
        int age = 18;
        string result = (age >= 18) ? "Reşit" : "Reşit değil";
        Console.WriteLine("\nKoşul (Ternary) Operatörü:");
        Console.WriteLine($"age >= 18 ? \"Reşit\" : \"Reşit değil\" -> {result}");
    }
}
