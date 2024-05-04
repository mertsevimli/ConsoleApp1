Console.WriteLine("Konu 03 Operatorler!");
Console.WriteLine("1-Aritmetik Operatörler");
int sayi1 = 3;
int sayi2 = 4;
int sayi3 = 5;
Console.WriteLine();
Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2: {sayi2} sayi3: {sayi3}");
Console.WriteLine("1234" + sayi3);
System.Console.WriteLine();
System.Console.WriteLine("Hesaplama İşlemleri: ");
Console.WriteLine("sayi1 + sayi2" +(sayi1 + sayi2));
Console.WriteLine("sayi1 - sayi2" + (sayi1 - sayi2)); //hesaplama işlemlerinde parantez
Console.WriteLine("sayi1 * sayi2" + (sayi1 * sayi2));
Console.WriteLine("sayi1 / sayi2" + (sayi1 / sayi2));
System.Console.WriteLine("sayi1 % sayi2:" + (sayi1 % sayi2));

Console.WriteLine();

System.Console.WriteLine("Artırım ve Azaltım operatörleri");

sayi2++;// Bir değişkendeki 1 artırmak için
System.Console.WriteLine("sayi2" + sayi2);
sayi2--;// Bir değişendeki değeri 1 eksiltmek için
System.Console.WriteLine("sayi2:" + sayi2);

System.Console.WriteLine();
System.Console.WriteLine("atama operatörleri");
System.Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2: {sayi2} sayi3: {sayi3}");
System.Console.WriteLine("sayi1 + sayi2 = " + (sayi1 += sayi2));
System.Console.WriteLine("sayi1 - sayi2 = " + (sayi1 -= sayi2)); //hesaplama işlemlerinde parantez
System.Console.WriteLine("sayi1 * sayi2 = " + (sayi1 *= sayi2));
System.Console.WriteLine("sayi1 / sayi2 = " + (sayi1 /= sayi2));
System.Console.WriteLine("sayi1 % sayi2: = " + (sayi1 %= sayi2));

System.Console.WriteLine();
System.Console.WriteLine("ilişkisel Operatörler");// birden fazla değeri karşılaştırıp aralarındaki durumu öğrenmek için kullanırız. Bunu .net kendisi belirliyor koda göre
System.Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2: {sayi2} sayi3: {sayi3}");
System.Console.WriteLine("sayı 1 sayı 2 ye eşit mi? " + (sayi1 == sayi2));
System.Console.WriteLine("sayı 1 sayı 2 ye eşit  değil mi? " + (sayi1 != sayi2));
System.Console.WriteLine("sayı 1 sayı 2 den büyük mü?  " + (sayi1 > sayi2));
System.Console.WriteLine("sayı 1 sayı 2 küçük mü? " + (sayi1 < sayi2));
System.Console.WriteLine("sayı 1 sayı 2 den küçük mü veya sayılar eşit mi ? " + (sayi1 <= sayi2));
System.Console.WriteLine("sayı 1 sayı 2 den büyük mü veya sayılar eşit mi ?  " + (sayi1 >= sayi2));


System.Console.WriteLine("Ternary Operatörü");// eğer karşılaştırma için 2 değer kullanıcaksak karşılaştırmanın kısayolu olarak kullanırız.
System.Console.WriteLine(" Ternary: " + ((sayi1 == sayi2) ? "sayı 1  sayı 2 ye eşit" :  "sayı 1 sayı 2 ye eşit değil"));


System.Console.WriteLine();
System.Console.WriteLine("Mantıksal Operatörler");
System.Console.WriteLine("And & Operatörü");
System.Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2: {sayi2} sayi3: {sayi3}");
System.Console.WriteLine("sayı 1 sayı 2 ye eşit mi? " + (sayi1 == sayi2));
System.Console.WriteLine("sayı 1 sayı 2 den büyük mü?  " + (sayi1 > sayi2));
System.Console.WriteLine("sayı 1 sayı 2 ye eşit mi?  ve sayı 1 sayı 2 den küçük mü?  " + ((sayi1 == sayi2) && (sayi1 < sayi2)));
// && işareti ve anlamına gelmektedir bunun sol ve sağ tarafındakilerin şartı tutması gerekmektedir ** //
// iki değerinde  true sonucu vermesi lazm 1 tanesi false olması durumunda sonuç False olur.


System.Console.WriteLine();
System.Console.WriteLine("Veya || Operatörü"); // option tuşu ile büyüktür küçüktür işaretine basınca cıkıyor.
System.Console.WriteLine("sayı 1 sayı 2 ye eşit mi?  ve sayı 1 sayı 2 den küçük mü?  " + ((sayi1 == sayi2) || (sayi1 < sayi2)));
// şartlardan 1 tanesi true olması durumunda geri dçnüş değeri true olur, tüm şartlar false ise false döner.

// || veya operatörü biri doğru ise True döner  && ise iki şartında doğru olmasını ister.


