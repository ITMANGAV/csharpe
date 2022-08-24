int ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return ack(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return ack(m - 1, ack(m, n - 1));
    }
    else
        return n + 1;
}
int ReadData(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
int m = ReadData("Введите натуральное число M: ");
int n = ReadData("Введите натуральное число N: ");
Console.WriteLine(ack(m, n));
