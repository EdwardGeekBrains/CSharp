/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int CountOfDigits(int number)
{
    int count = 1;
    while (number >= 10)
    {
        number /= 10;
        count += 1;
    }
    return count;
}

int CountOfDigitVer2(int number)
{
    return number.ToString().Length;
}

int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CountOfDigits(number));
System.Console.WriteLine(CountOfDigitVer2(number));