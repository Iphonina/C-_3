// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
//между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите коoрдинату x для первой точки: ");
int xa = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y для первой точки: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z для первой точки: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите коoрдинату x для второй точки: ");
int xb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y для второй точки: ");
int yb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z для второй точки: ");
int zb = Convert.ToInt32(Console.ReadLine());

double dx = xb - xa;
double dy = yb - ya;
double dz = zb - za;

double d = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2) + Math.Pow(dz, 2));

Console.WriteLine($"Расстояние между точками {Math.Round(d, 2)}");
