m1: Console.Write("Введите трехзначное число:");
string? number = Console.ReadLine();
int num = int.Parse(number);
if ((num < 100) || (num > 999))
{
    Console.WriteLine("НЕ трехзначное число!");
    goto m1;
}
int res = num / 10 % 10;
Console.WriteLine(res);

