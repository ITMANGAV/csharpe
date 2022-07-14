m1: Console.Write("Введите число:");
string? number = Console.ReadLine();
if (number == "")
{
    goto m1;
}
int num = int.Parse(number);
if (num < 100)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    char[] res = number.ToCharArray();
    Console.WriteLine(res[2]);
}

