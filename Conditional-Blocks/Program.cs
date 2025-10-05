// Koşul ifadeleri (if-else, switch)

// if-else yapısı

string isim = "Ahmet";
string sifre = "12345";

if (isim == "Ahmet" && sifre == "12345")
{
    Console.WriteLine("Giriş başarılı!");
}
else if (isim == "Ahmet" && sifre != "12345")
{
    Console.WriteLine("Şifre yanlış!");
}
else
{
    Console.WriteLine("Kullanıcı bulunamadı!");
}

// elif yapısı
Console.Write("Hangi gün? ");
string gun = Console.ReadLine();


if (gun == "Pazartesi")
{
    Console.WriteLine("Haftanın ilk günü");
}
else if (gun == "Salı")
{
    Console.WriteLine("Haftanın ikinci günü");
}
else if (gun == "Çarşamba")
{
    Console.WriteLine("Haftanın üçüncü günü");
}
else if (gun == "Perşembe")
{
    Console.WriteLine("Haftanın dördüncü günü");
}
else if (gun == "Cuma")
{
    Console.WriteLine("Haftanın beşinci günü");
}
else if (gun == "Cumartesi")
{
    Console.WriteLine("Haftanın altıncı günü");
}
else if (gun == "Pazar")
{
    Console.WriteLine("Haftanın yedinci günü");
}
else
{
    Console.WriteLine("Geçersiz gün girdiniz!");
}

// Switch-case yapısı
switch (gun)
{
    case "Pazartesi":
        Console.WriteLine("Haftanın ilk günü (switch-case)");
        break;
    case "Salı":
        Console.WriteLine("Haftanın ikinci günü (switch-case)");
        break;
    case "Çarşamba":
        Console.WriteLine("Haftanın üçüncü günü (switch-case)");
        break;
    case "Perşembe":
        Console.WriteLine("Haftanın dördüncü günü (switch-case)");
        break;
    case "Cuma":
        Console.WriteLine("Haftanın beşinci günü (switch-case)");
        break;
    case "Cumartesi":
        Console.WriteLine("Haftanın altıncı günü (switch-case)");
        break;
    case "Pazar":
        Console.WriteLine("Haftanın yedinci günü (switch-case)");
        break;
    default:
        Console.WriteLine("Geçersiz gün girdiniz! (switch-case)");
        break;
}

// ternary operatör

string sonuc = (gun == "Pazar") ? "Bugün Pazar!" : "Bugün Pazar değil!";
Console.WriteLine(sonuc);