// Напишите программу, которая принимает на вход координатnew двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

Console.Clear();
Console.Write("Введите коoрдинату x для первой точки: ");
int xa = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y для первой точки: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x для второй точки точки: ");
int xb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y для второй точки: ");
int yb = Convert.ToInt32(Console.ReadLine());

double l = Math.Sqrt((xb-xa)*(xb-xa) + (yb-ya)*(yb-ya)); //Math.Pow(d, 2)
Console.Write($"Расстояние между точками {Math.Round(l, 2)}");
