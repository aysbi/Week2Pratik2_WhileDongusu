## While Döngüsü Konsol Uygulaması

# Genel Özellikler
Bu proje, C# dilinde while döngüsü kullanılarak yazılmış bir örnek uygulamadır. Proje, bir dizi işlevi gerçekleştirmek üzere döngü yapılarını gösterir ve Visual Studio 17 ile oluşturulmuştur.

# Proje İçeriği
* while Döngüsü Kullanımı: Bir dizi tekrarlı işlemi gerçekleştirmek için while döngüsü kullanılır.
* Debug ve Release Yapıları: Proje, Debug ve Release yapılandırmalarıyla çalıştırılabilir.

# Geliştirme Ortamı
* Visual Studio Sürümü: 17.11.35312.102
* .NET Framework: Proje, .NET 5.0 veya daha üstü bir sürümde çalıştırılabilir.

# Kod İçeriği
```csharp
int i = 1;

while (i <= 10)
{
    Console.WriteLine(i + " - Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}
```
Bu kod ile koşul 10'dan küçük veya eşit olana dek devam etmektedir. 1'den başlayarak 10 defa ekrana ''Kendime inanıyorum, ben bu yazılım işini hallederim!'' yazılmaktadır.  

```csharp
int j = 1;

while (j <= 20)
{
    Console.WriteLine(j);
    j++;
}
```
1'den 20'ye kadar sayıları ekrana yazdırmaktadır. Koşul 20 ile belirlenmiştir.
```csharp
int k = 1;

while (k <= 20)
{
    if (k % 2 == 0)
        Console.WriteLine(k);
    k++;
}
```
Sadece çift sayıları göstermektedir. Koşul değişkeni 2'şer olarak arttırılmaktadır.
```csharp
int l = 50;
int toplam = 0;

while (l <=150)
{
    toplam += l;
    l++;
}
Console.WriteLine("50 ile 150 arasindaki sayilarin toplami: " + toplam);
```
Ekrana 50'den 150'ye kadar olan sayıların toplamını yazmaktadır. toplam değişkeni her seferinde 1 arttrılmış olan koşul değişkeni ile toplanarak döngüden çıkınca toplam değeri vermektedir. 
```csharp
int m = 1;
int toplamTek = 0;
int toplamCift =  0;

while (m <= 120)
{
    if ((m % 2) == 0)
        toplamCift += m;
    else 
        toplamTek += m;
    m++;
}

Console.WriteLine("1den 120e kadar olan tek sayilarin toplami: " + toplamTek);
Console.WriteLine("1den 120ye kadar olan cift sayilarin toplami: " + toplamCift);
```
Bu kodda hem while döngüsü hem if statement kullanılmıştır. Sayı çift ise döngüde çift sayıların toplamına eklenir tek ise tek sayıların toplamına eklenmektedir. 
Son olarak da bu sayıların toplamını ayrı ayrı ekrana yazmaktadır. 

# Örnek Çıktı
```csharp
1-Kendime inanıyorum, ben bu yazılım işini hallederim!
2-Kendime inanıyorum, ben bu yazılım işini hallederim!
3-Kendime inanıyorum, ben bu yazılım işini hallederim!
4-Kendime inanıyorum, ben bu yazılım işini hallederim!
5-Kendime inanıyorum, ben bu yazılım işini hallederim!
6-Kendime inanıyorum, ben bu yazılım işini hallederim!
7-Kendime inanıyorum, ben bu yazılım işini hallederim!
8-Kendime inanıyorum, ben bu yazılım işini hallederim!
9-Kendime inanıyorum, ben bu yazılım işini hallederim!
10-Kendime inanıyorum, ben bu yazılım işini hallederim!
1
2
3
4
5
6
7
8
9
10
11
12
13
14
15
16
17
18
19
20
2
4
6
8
10
12
14
16
18
50 ile 150 arasindaki sayilarin toplami = 9950
1 ve 120 arasindaki tek sayilarin toplami = 3600
1 ve 120 arasindaki cift sayilarin toplami = 3540
```
