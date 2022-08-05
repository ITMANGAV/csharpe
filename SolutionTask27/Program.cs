string readStr()
{
    Console.Write("Введите число: ");
    string? str = Console.ReadLine();
    return str;
}
string stroka = readStr();
void solutionChar(string stroka)
{
    char[] arr = stroka.ToCharArray();
    int[] Aint = Array.ConvertAll(arr, c => (int)Char.GetNumericValue(c));
    int sum = 0;
    for (int i = 0; i < Aint.Length; i++)
    {
        sum += Aint[i];
    }
    Console.WriteLine($"Сумма цифр числа {stroka} -> {sum}");

}
void solutionSimple(string stroka)
{
    int digit = int.Parse(stroka);
    int d = 1;
    int e = 1;
    int sum = 0;
    while (d > 0 && e > 0)
    {
        d = digit / 10;
        e = digit % 10;
        sum += e;
        digit = d;
    }
    Console.WriteLine($"Сумма цифр числа {stroka} -> {sum}");
}
DateTime t = DateTime.Now;
solutionChar(stroka);
Console.WriteLine(DateTime.Now - t);
t = DateTime.Now;
solutionSimple(stroka);
Console.WriteLine(DateTime.Now - t);
