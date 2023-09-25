/* Напишите прошрамму, которая принимает на вход координаты двух точек и находит
расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7, -5); B (1, -1) -> 7,21
*/

int [] ReadPointCoords()
{
int x = Convert.ToInt32(Console.ReadLine()!);
int y = Convert.ToInt32(Console.ReadLine()!);
int [] point = new int [] { x, y };
return point;
}

double FindDistance (int [] pointA, int[] pointB)
{
    int ax = pointA[0];
    int ay = pointA[1];
    int bx = pointB[0];
    int by = pointB[1];
    double distance = Math.Sqrt((ax-bx)*(ax-bx)+(ay-by)*(ay-by));
    return distance;
}
int [] pointA = ReadPointCoords();
int [] pointB = ReadPointCoords();
System.Console.WriteLine($"{FindDistance(pointA, pointB):F2}");