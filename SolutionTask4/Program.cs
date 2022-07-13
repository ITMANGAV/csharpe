string? a = Console.ReadLine();
string? b = Console.ReadLine();
string? c = Console.ReadLine();
int a1 = int.Parse(a);
int b1 = int.Parse(b);
int c1 = int.Parse(c);
Console.Write("Первое число: ");
Console.WriteLine(a1);
Console.Write("Второе число: ");
Console.WriteLine(b1);
Console.Write("Третье число: ");
Console.WriteLine(c1);
if (a1 > b1)
{
    if (a1 > c1)
    {
        Console.WriteLine("Первое число большее");
    }
    else
    {
        Console.WriteLine("Третье число большее");
    }
}
else
{
    if (b1 > c1)
    {
        Console.WriteLine("Второе число большее");
    }
    else
    {
        Console.WriteLine("Третье число большее");
    }
}