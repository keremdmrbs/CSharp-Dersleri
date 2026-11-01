// Veri Tipleri

// Tam SAyı: int, long, short, byte
// Ondalıklı Sayı: float, double, decimal
// Mantıksal: bool
// Karakter: char
// Metinsel: string
// Doğru veya Yanlış: bool

int sayi1 = 10; // Tam sayı
long sayi2 = 10000000000; // Uzun tam sayı
char cinsiyet = 'E'; // Tek tırnak içinde yazılır
string isim = "Ahmet"; // Çift tırnak içinde yazılır
bool sayi110mu = true; // Mantıksal değer
decimal fiyat = 19.99m; // Ondalıklı sayı, m ile belirtilir!!
float pi = 3.14f; /* Ondalıklı sayı, f ile belirtilir!! Aralarındaki fark: 
float daha az hassasiyetlidir, decimal ise daha hassastır ve finansal işlemler 
için kullanılır.*/

Console.WriteLine(sayi1);
Console.WriteLine(sayi2);
Console.WriteLine(cinsiyet);
Console.WriteLine(isim);
Console.WriteLine(sayi110mu);
Console.WriteLine(fiyat);
Console.WriteLine(pi);