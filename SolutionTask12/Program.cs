string? number1 = Console.ReadLine();
string? number2 = Console.ReadLine();
int num1 = int.Parse(number1);
int num2 = int.Parse(number2);
int bak = num1 % num2;
if (bak == 0)
{
    Console.WriteLine(num1 + "," + num2 + " -> " + "кратно");
}
else
{
    Console.WriteLine(num1 + "," + num2 + " -> " + "некратно, остаток " + bak);
}

