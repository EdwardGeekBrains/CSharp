/*Задача 22: напишите программу , которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N
5 -> 1, 4, 9, 16, 25. 
2 -> 1,4
*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Квадраты от 1 до {number}:");
for (int i = 1; i <= number; i++)
{
    int square = i * i;
    Console.WriteLine($"{i}^2 = {square}");
}