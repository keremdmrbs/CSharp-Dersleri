/*
    Dışarıdan veri alma ve girme, ardından bunu bir değişkene atama işlemi yapma örneği.
*/

Console.Write("Bir sayi girin: ");
var girilenSayi = Convert.ToInt16(Console.ReadLine()!); // Girilen değeri int tipine dönüştürerek girilenSayi değişkenine atıyoruz. 
// Sondaki ünlem işareti (!) null değer gelmeyeceğini garanti eder. Eğer kullanıcı bir sayı girmezse, program hata verir.
// Convert.ToInt16() metodu, girilen değeri 16 bitlik bir tamsayıya dönüştürür (string to int).
// Eğer kullanıcı geçerli bir sayı girmezse, program hata verir.

/*
string girilenSayi = Console.ReadLine("Bir sayı girin: "); şeklinde de yazılabilir. 
Ancak bu durumda girilenSayi değişkeni string tipinde olur. 
Eğer sayısal bir işlem yapmak istiyorsak, girilen değeri int veya double gibi sayısal bir tipe dönüştürmemiz gerekir.
*/

Console.Write("Bir sayi daha girin: ");
var girilenSayi2 = Convert.ToInt16(Console.ReadLine()!); // Girilen ikinci değeri int tipine dönüştürerek girilenSayi2 değişkenine atıyoruz.

Console.WriteLine(girilenSayi + girilenSayi2); // Bu satırda girilen iki sayıyı toplamak yerine string olarak birleştirir.


    // Veri Tipi Dönüşümleri (Type Casting) Örnekleri:
    // implicit conversion (implicit casting) - otomatik dönüşüm
    int a = 10;
    long b = a; // int tipindeki a değişkeni long tipine otomatik olarak dönüştürülür.
    
    // explicit conversion (explicit casting) - açık dönüşüm
    double c = 10.5;
    int d = (int)c; // double tipindeki c değişkeni int tipine dönüştürülür. Lakin bu işlem sırasında ondalık kısmı kaybolur 
    // ve d değişkeni 10 değerini alır.

    // Convert sınıfı ile dönüşüm
    string e = "20";
    int f = Convert.ToInt16(e); // string tipindeki e değişkeni int tipine dönüştürülür.

    // Parse metodu ile dönüşüm
    string g = "30";
    int h = int.Parse(g); /* string tipindeki g değişkeni int tipine dönüştürülür. Convert.ToInt16() ile aynı işlemi yapar.
    Aralarındaki fark, Parse metodu sadece string tipindeki verileri dönüştürebilirken, 
    Convert sınıfı farklı veri tiplerini de dönüştürebilir.
    */

    // Yanlış veri tipine dönüştürme örneği
    /* string i = "abc";
    int j = Convert.ToInt16(i); */
    // Bu satır hata verecektir, çünkü "abc" bir sayısal değer değildir.

    /* int k = 21;
    byte s = k; */ 
    // Bu satır hata verecektir, çünkü int veri tipi byte veri tipinden daha fazla değerler alabilir.
    // Dolayısıyla int veri tipi byte veri tipine otomatik olarak dönüştürülemez. Ama eğer:
    
    int x = 21;
    byte z = (byte)x; 
    // Yaparsak int olarak tanımlanan x değişkenini kendimiz manuel olarak byte tipine dönüştürmüş oluruz. 
    // Bu işlem sırasında veri kaybı yaşanabilir. Çünkü byte veri tipi 0-255 aralığında değerler alabilir. 
    // Eğer x değişkeni 255'ten büyük bir değer alırsa, z değişkeni yanlış bir değer alır ve program hata verebilir.

    // Girilen sayısal veriyi string tipine dönüştürme örneği
    
    int sayi = 100;
    string sayiString = sayi.ToString(); // int tipindeki sayi değişkenini string tipine dönüştürür ve sayiString değişkenine atar. 
    // sayi.ToString() metodu, sayısal bir değeri string tipine dönüştürmek için kullanılır. (string)sayi şeklinde de yazılabilir. 
    // Ancak ToString() metodu daha yaygın olarak kullanılır. Aynı zamanda ToString() metodu, sayısal değeri string tipine dönüştürürken,
    // sayısal değerin formatını da belirleyebiliriz. 
    // Örneğin,
    double sayi2 = 1234.5678;
    string sayi2String = sayi2.ToString("0.00"); /* sayi2 değişkenini string tipine dönüştürür ve sayi2String değişkenine atar. 
    0.00 formatı ile sayısal değerin sadece iki ondalık basamağını alır ve sayi2String değişkenine atar.
    Sonuç olarak sayi2String değişkeni "1234.57" değerini alır. Eğer 0.0 formatı kullanırsak, 
    sayısal değerin sadece bir ondalık basamağını alır ve sayi2String değişkenine atar. 
    Böylece sayi2String değişkeni "1234.6" değerini */