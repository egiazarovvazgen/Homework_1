// Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.WriteLine("Введите число n_1: ");
int n_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число n_2: ");
int n_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число n_3: ");
int n_3 = int.Parse(Console.ReadLine()!);

int max = n_1;

if (n_1 > max) max = n_1;
if (n_2 > max) max = n_2;
if (n_3 > max) max = n_3;

Console.Write("max = ");
Console.WriteLine(max);