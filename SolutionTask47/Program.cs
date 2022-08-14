Console.WriteLine("Введите количество строк 2х мерного массива: ");
int row = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите количество столбцов 2х мерного массива: ");
int col = int.Parse(Console.ReadLine() ?? "");


double[,] CreateArray(int row, int col)
{
    double[,] outArray = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            outArray[i, j] = new Random().NextDouble() * 100;
        }
    }
    return outArray;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write("{0,6:F2} ", array[i, j]);
        }
        Console.WriteLine();
    }
}
double[,] oArr = CreateArray(row, col);
PrintArray(oArr);