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
// Метод создает массив произведений 2х входных массивов
int[,] Matrix(int[,] array1, int[,] array2)
{
    int[,] outArray = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            outArray[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return outArray;
}

int[,] arr1 = CreateArray(row, col);
int[,] arr2 = CreateArray(row, col);
PrintArray(arr1);
PrintArray(arr2);
PrintArray(Matrix(arr1, arr2));