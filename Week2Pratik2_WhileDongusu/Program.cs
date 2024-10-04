//Bu pratik uygulama 5 aşamadan oluşuyor. Aşağıdaki alıştırmaları while kullanarak yapınız.

//1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

int i = 1;

while (i <= 10)
{
    Console.WriteLine(i + " - Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}

//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

int j = 1;

while (j <= 20)
{
    Console.WriteLine(j);
    j++;
}

//3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

int k = 1;

while (k <= 20)
{
    if (k % 2 == 0)
        Console.WriteLine(k);
    k++;
}

//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

int l = 50;
int toplam = 0;

while (l <=150)
{
    toplam += l;
    l++;
}
Console.WriteLine("50 ile 150 arasindaki sayilarin toplami: " + toplam);

//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

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

Console.ReadKey();
