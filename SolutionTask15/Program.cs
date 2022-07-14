m1: Console.Write("Введите число, обозначавшее день недели:");
string? number = Console.ReadLine();
if (number == "") { goto m1; }
int num = int.Parse(number);
if (num < 1 || num > 7) { Console.WriteLine("Число не коректное, попробуйте ещё раз!"); goto m1; }
if (num > 5)
{
    Console.WriteLine(num + " -> Да, выходной.");
}
else
{
    Console.WriteLine(num + " -> Нет, рабочий.");
}