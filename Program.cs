
// Birinci asama Ekrana 10 kere "Kendime inanıyorum, Ben bu yazilim isini hallederim" yazdıran for döngüsü.
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Kendime inanıyorum, Ben bu yazilim isini hallederim!");
}
Console.WriteLine("----------------------------------");

// İkinci asama 1 ile 20 arasındaki sayilari konsol ekranına yazdıran for döngüsü.
for (int i = 1; i<=20; i++)
{
    Console.WriteLine($"{i}");
}
Console.WriteLine("----------------------------------");
// Üçüncü aşama 1 ile 20 arasındaki çift sayıları ekrana yazdıran for döngüsü.
for(int i = 2; i <= 20; i+=2)
{
    Console.WriteLine($"{i}");
}
Console.WriteLine("----------------------------------");
// Dördüncü aşama 50 ile 150 arasındaki sayiların toplamını ekrana yazdıran for döngüsü.
int toplam = 0;
for(int i = 50; i <= 150; i++)
{
    toplam += i;
}
    Console.WriteLine($"50 ile 150 arasındaki sayilarin toplami: {toplam}");
Console.WriteLine("----------------------------------");
// Beşinci aşama 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdıran for döngüsü.
int sum = 0;
for(int i = 0; i <= 120; i+=2)
{
    sum += i;
}
Console.WriteLine($"Cift sayilarin toplami: {sum}");
int oddNum = 0;
for(int i = 1; i < 120; i+=2)
{
    oddNum += i;
    
}
Console.WriteLine($"Tek sayilarin toplami: {oddNum}");