// See https://aka.ms/new-console-template for more information

int[] numbers = { 13, 8, -9, 52, 4, 5 };

//Dizi Listelemesi 
int index = 0;
Console.Write("Dizi: ");
while (index < numbers.Length)
{
    Console.Write(numbers[index++] + " ");
}
Console.Write("\n");

//Dizideki En Büyük Eleman
int enBuyuk = numbers[0], i = 0;
while (i < numbers.Length)
{
    if (enBuyuk < numbers[i])
    {
        enBuyuk = numbers[i];
    }
    i++;
}
Console.WriteLine($"En Büyük Sayı: {enBuyuk}");

//Dizideki En Küçük Eleman
int enKucuk = numbers[0], j = 0;
while (j < numbers.Length)
{
    if (numbers[j] < enKucuk)
    {
        enKucuk = numbers[j];
    }
    j++;
}
Console.WriteLine($"En Küçük Sayı: {enKucuk}");

//Dizideki Elemanların Toplamı
int k = 0, sum = 0;
while (k < numbers.Length)
{
    sum += numbers[k++];
}
Console.WriteLine($"Toplamları: {sum}");

//Ortalamaları
double avg = (double)sum / (double)numbers.Length;
Console.WriteLine($"Ortalamaları: {avg}");

