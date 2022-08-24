int ReadData(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
int sum = 0;
//Метод сумирует натуральные числа от m до n
int SumNatNumbers(int m, int n)
{
    if (m == n + 1) { return sum; }
    sum += m;
    SumNatNumbers(++m, n);
    return sum;
}

int m = ReadData("Введите натуральное число M, начало отсчета: ");
int n = ReadData("Введите натуральное число N, конец отсчета: ");
int otvet = SumNatNumbers(m, n);
Console.WriteLine($"Сумма = {otvet}");