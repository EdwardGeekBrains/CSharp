/* Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9
5 -> 1, 8, 27, 64, 125
*/

    Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        void PrintCubes(int number)
    {
        Console.WriteLine($"Кубы от 1 до {number}:");
        for (int i = 1; i <= number; i++)
        {
            int cube = i * i * i;
            Console.WriteLine($"{i}^3 = {cube}");
        }
    }
        PrintCubes(number);