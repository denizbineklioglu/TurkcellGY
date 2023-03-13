// See https://aka.ms/new-console-template for more information
int[] numbers = { 8, 14, 52, -8, 1, 3 };

//Dizi Listelemesi 
Console.Write("Dizi: ");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}
Console.Write("\n");

//Dizideki En Büyük Sayı
int enBuyuk = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    enBuyuk = numbers[i] > enBuyuk ? numbers[i] : enBuyuk;
}
Console.WriteLine($"En Büyük Sayı: {enBuyuk}");

//Dizideki En Küçük Sayı
int enKucuk = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < enKucuk)
    {
        enKucuk = numbers[i];
    }
}
Console.WriteLine($"En Küçük Sayı: {enKucuk}");

//Dizideki Elemanların Toplamı
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
Console.WriteLine($"Elemanların Toplamları: {sum}");

//Dizideki Elemanların Ortalaması
double avg = (double)sum / (double)numbers.Length;
Console.WriteLine($"Elemanların Ortalaması: {avg}");

//Leetcode Search Insert Position Algoritma Çözümü
int[] nums = { 1, 3, 5, 6 };
int target = 7, u = 0;
for (; u < nums.Length; u++)
{
    if (nums[u] == target)
    {
        break;
    }
    else
    {
        if (nums[u] > target)
        {
            break;
        }
    }
}
Console.WriteLine(u);

//Leetcode Sıngle Number Çözümü
int[] single = { 4, 1, 2, 1, 2 };
int s = 0;
for (; s < nums.Length; s++)
{
    int count = 0;
    for (int j = 0; j < single.Length; j++)
    {
        if (single[s] == single[j])
        {
            count++;
        }
    }
    if (count == 1)
    {
        break;
    }
}
Console.WriteLine($"Single Number : {single[s]}");


