// Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.WriteLine("Введите число n_1: ");
int n_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число n_2: ");
int n_2 = int.Parse(Console.ReadLine()!);

if (n_1 > n_2)
{
    Console.WriteLine("Число n_1 - большее, число n_2 - меньшее");
}
else
{
    Console.WriteLine("Число n_2 - большее, число n_1 - меньшее");
}