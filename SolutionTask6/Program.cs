Console.Clear();
string? number = Console.ReadLine();
int num = int.Parse(number);
int ost = num % 2;
if (ost == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}

