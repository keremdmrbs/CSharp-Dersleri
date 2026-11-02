/*
    Strings: karakter Dizileri
*/

char cinsiyet = 'E'; // char tipinde bir değişken tanımladık ve değer atadık. char değişkeni tanımlanırken tek tırnak kullanılır.
string cinsiyet2 = "Erkek";

Console.Write("Adınızı Giriniz: ");
string? ad = Console.ReadLine(); 
//Dışarıdan aldığımız veriyi string tipinde bir değişkene atadık. 
//Console.ReadLine() metodu ile kullanıcıdan veri alıyoruz.

Console.Write("Soyadınızı Giriniz: ");
string? soyad = Console.ReadLine();

Console.Write("Yaşınızı Giriniz: ");
string? yas = Console.ReadLine();


// String birleştirme işlemi (String Concat)
//  Console.WriteLine( ad + " " + soyad + " isimli kişi şu anda " + yas + " yaşında ve C# öğreniyor.");

// String birleştirme işlemi (String Interpolation)
Console.WriteLine($"{ad} {soyad} isimli kişi şu anda {yas} yaşında ve C# öğreniyor.");