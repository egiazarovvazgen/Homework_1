// Программа, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

if (n % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}