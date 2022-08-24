int ReadData(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

//Метод печатает натуральныу числа от m до n
void Natnumbers(int m, int n)
{
    if (m == n + 1) { return; }
    Console.Write(m + " ");
    Natnumbers(++m, n);

}

int m = ReadData("Введите натуральное число M, начало отсчета: ");
int n = ReadData("Введите натуральное число N, конец отсчета: ");
Natnumbers(m, n);