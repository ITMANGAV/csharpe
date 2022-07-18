Console.Write("Введите число, (до 15):");
string? number = Console.ReadLine();
int num = int.Parse(number);
double[,] kub = new double[num + 1, num + 1];
for (int i = 0; i <= num; i++)
{
    double k = Math.Pow(i, 3);
    kub[0, i] = i;
    kub[1, i] = k;
    //Console.WriteLine(kub[0, i] + " " + kub[1, i]);
}
void printKub(double[,] ar)
{
    for (int y = 0; y < 2; y++)
    {
        for (int x = 0; x <= num; x++)
        {
            Console.Write("--------");
        }
        Console.WriteLine("");

        for (int x = 0; x <= num; x++)
        {
            Console.Write("| " + ar[y, x] + "\t");
        }
        Console.WriteLine("|");
    }
    for (int x = 0; x <= num; x++)
    {
        Console.Write("--------");
    }
    Console.WriteLine("");
}

printKub(kub);
