Console.Write("Введите пятизначное число:");
string? number = Console.ReadLine();
int num = int.Parse(number);
if ((num / 10000 > 9) || (num / 10000 == 0))
{
    Console.Write("Введенное число не пятизначное!");
}
else
{
    int n1 = num / 10000;
    int n2 = (num - n1 * 10000) / 1000;
    int n3 = (num - n1 * 10000 - n2 * 1000) / 100;
    int n4 = (num - n1 * 10000 - n2 * 1000 - n3 * 100) / 10;
    int n5 = num % 10;
    int digit = n1 * 1000 + n2 * 100 + n4 * 10 + n5;
    //Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
    //Console.WriteLine(digit);
    var polindrom = new Dictionary<int, int>();

    for (int i = 1; i < 10; i++)
    {
        for (int j = 1; j < 10; j++)
        {
            polindrom.Add(i * 1000 + j * 100 + j * 10 + i, 1);

        }
    }

    if (polindrom.ContainsKey(digit))
    {
        Console.Write("Введённое число палиндром!");
    }
    else
    {
        Console.Write("Введённое число не палиндром!");
    }
}
