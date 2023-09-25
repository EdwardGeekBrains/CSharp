/* Задача 18: Напишите программу,которая по заданному номеру четверти показывает диапозон возможных координат
точек в этой четверти (x и y)
*/

void PrintRange(int part)
{
    if (part == 1)
{
    System.Console.WriteLine("x>0, y>0");
}
else if (part == 2)
{
    System.Console.WriteLine("x<0, y>0");
}
else if (part == 3)
{
    System.Console.WriteLine("x<0, y<0");
}else if (part == 4)
{
    System.Console.WriteLine("x>0, y>0");
}
else
{
    System.Console.WriteLine("error");
}
}
int part = Convert.ToInt32(Console.ReadLine());
PrintRange(part);