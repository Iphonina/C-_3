// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
double number = 1;

while(count <= N)
{
    number = Math.Pow(count, 3);
    count++;
    Console.Write($"{number}, ");
}
