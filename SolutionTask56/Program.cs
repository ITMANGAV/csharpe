Console.WriteLine("Введите количество строк 2х мерного массива: ");
int row = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите количество столбцов 2х мерного массива: ");
int col = int.Parse(Console.ReadLine() ?? "");

// Метод создает массив 
int[,] CreateArray(int row, int col)
{
    int[,] outArray = new int[row, col];
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
void PrintArray(int[,] array)
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
// Метод подсчитывает значения элементов в строках массива
int[] SummaValueRow(int[,] array)
{
    int[] sumValueRow = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumValueRow[i] += array[i, j];
        }

    }
    return sumValueRow;
}
// Метод печатает индекс минимального значения 
void PrintMinSumRow(int[] array)
{
    int minValue = int.MaxValue;
    int numberMinStr = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (minValue > array[i])
        {
            minValue = array[i];
            numberMinStr = i + 1;
        }
    }
    Console.WriteLine($"{numberMinStr} строка минимальна по суммарному значению.");
}

int[,] outArray = CreateArray(row, col);
PrintArray(outArray);
PrintMinSumRow(SummaValueRow(outArray));