Console.WriteLine("Введите количество строк 2х мерного массива: ");
int row = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите количество столбцов 2х мерного массива: ");
int col = int.Parse(Console.ReadLine() ?? "");

// Метод создает массив 
double[,] CreateArray(int row, int col)
{
    double[,] outArray = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            outArray[i, j] = new Random().Next(1, 10);
        }
    }
    return outArray;
}
// Метод печатает массив
void PrintArray(double[,] array)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{array[i, j]}" + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
// Метод печатает средниt значения по столбам
void PrintMiddleValue(double[,] array)
{
    for (int i = 0; i < col; i++)
    {
        double sum = 0;
        for (int j = 0; j < row; j++)
        {
            sum += array[j, i];
        }
        double middleValue = sum / row;
        Console.Write("{0,1:F1}", middleValue);
        Console.Write("\t");
    }
}

double[,] oArr = CreateArray(row, col);
PrintArray(oArr);
PrintMiddleValue(oArr);