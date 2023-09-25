/* 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X и Y не равны 0
и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

int NumberQuaterOfPlane(int x, int y)
{
    if (x > 0 && y >0) return 1;
    else if (x <0 && y>0) return 2;
    else if (x <0 && y<0) return 3;
    else if (x >0 && y<0) return 4;
    else return -1;
}

int numberOfPlane = NumberQuaterOfPlane(56, -5);
if (numberOfPlane == -1)
    Console.WriteLine("Ошибка!");
    else
    Console.WriteLine($"Номер четверти плоскости {numberOfPlane}");