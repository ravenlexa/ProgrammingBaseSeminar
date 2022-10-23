/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве */

double DistansionABin2D(int x1, int y1, int x2, int y2)
{
    double distasionAB = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
    return distasionAB;
}

System.Console.WriteLine( "Введите координаты двух точек");
System.Console.WriteLine( "Введите координаты первой точки: ");
System.Console.Write("x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine( "Введите координаты второй точки: ");
System.Console.Write("x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distasion = DistansionABin2D(x1, y1, x2, y2);
System.Console.WriteLine(distasion);