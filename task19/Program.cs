/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите пятизначное число: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPalindrome(number))
        {
            Console.WriteLine("Да, число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Нет, число не является палиндромом.");
        }
    }

    static bool IsPalindrome(int number)
    {
        string numString = number.ToString();
        int length = numString.Length;
        
        for (int i = 0; i < length / 2; i++)
        {
            if (numString[i] != numString[length - i - 1])
            {
                return false;
            }
        }
        
        return true;
    }
}
