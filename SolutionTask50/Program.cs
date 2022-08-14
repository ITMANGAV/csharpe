Console.WriteLine("Введите количество строк 2х мерного массива: ");
int row = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите количество столбцов 2х мерного массива: ");
int col = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите позицию элемента: ");
int position = int.Parse(Console.ReadLine() ?? "");

int[,] CreateArray(int row, int col)
{
    int[,] outArray = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            outArray[i, j] = new Random().Next(-9, 10);
        }
    }
    return outArray;
}

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
}

void Solution(int[,] array)
{
    int k = 1;
    if (row * col >= position && position > 0)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (k == position) { Console.WriteLine(array[i, j]); }
                k++;
            }
        }
    }
    else
    {
        Console.WriteLine($"{position} - такого позиции элемента в массиве нет.");
    }
}

int[,] oArr = CreateArray(row, col);
PrintArray(oArr);
Solution(oArr);