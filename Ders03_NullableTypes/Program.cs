// Nullable Types

int? maas = 20; // int veri tipinin varsayılan null değeri 0'dır
bool? isActive = null; 
// Veri tipinin sonuna "?" işareti koyarsak o veri tipinin null değer alabileceğini belirtmiş oluruz.

Console.WriteLine(maas.HasValue); // HasVaule sorulan değişkenin değerinin olup olmadığını bize söyler.
// Değeri varsa True, yoksa yani null ise False ekrana yazar.

Console.WriteLine(maas.GetValueOrDefault()); // maas değişkeninin değeri varsa değerini,
// yoksa da değişken veri tipinin varsayılan değerini ekrana yazar. İnt veri tipinin varsayılan değeri 0'dır.

Console.WriteLine(isActive.GetValueOrDefault()); // isActive değişkeninin değeri varsa değerini,
// yoksa da değişken veri tipinin varsayılan değerini ekrana yazar. Bool veri tipinin varsayılan değeri False'dur.