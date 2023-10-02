/* Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

int SumFrom1ToN (int n)
{
    int sum = 0;
    for (int i = 1; i<= n; i++)
    {
        sum += i;
    }
  return sum;
}

int SumFrom1ToNFast(int n)
{
    int sum = (1 + n) * n /2;
    return sum;
}

int n = 8;
Console.WriteLine(SumFrom1ToN(n));
Console.WriteLine(SumFrom1ToNFast(n));
