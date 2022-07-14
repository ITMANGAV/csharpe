string? number1 = Console.ReadLine();
int num1 = int.Parse(number1);
string? number2 = Console.ReadLine();
int num2 = int.Parse(number2);

if (num1 == num2 * num2 || num2 == num1 * num1)
{
    Console.WriteLine(num1 + " " + num2 + " Да");
}
else
{
    Console.WriteLine(num1 + " " + num2 + " Нет");
}
