string? number1 = Console.ReadLine();
int num1 = int.Parse(number1);
int bak = num1 % 7;
int bak2 = num1 % 23;
if (bak == 0 && bak2 == 0)
{
    Console.WriteLine(num1 + " кратно 7 и 23");
}
else
{
    Console.WriteLine(num1 + " некратно 7 и 23");
}
