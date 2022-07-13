string? a = Console.ReadLine();
string? b = Console.ReadLine();
int a1 = int.Parse(a);
int b1 = int.Parse(b);
Console.Write("Первой число - ");
Console.WriteLine(a1);
Console.Write("Второе число - ");
Console.WriteLine(b1);
if (a1 == b1)
{
    Console.WriteLine("Числа равны");
}
else
{
    if (a1 > b1)
    {
        Console.WriteLine("Первой число больше второго");
    }
    else
    {
        Console.WriteLine("Второе число больше первого");
    }
}
