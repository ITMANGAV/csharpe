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

// Метод сортирует строки массива вставками
int[,] InsertionSort(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            int j = i;
            while (j > 0 && result[r, j - 1] > array[r, i])
            {
                result[r, j] = result[r, j - 1];
                j--;
            }
            result[r, j] = array[r, i];
        }
    }
    return result;
}
int[,] outArray = CreateArray(row, col);
PrintArray(outArray);
PrintArray(InsertionSort(outArray));