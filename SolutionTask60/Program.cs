
HashSet<int> numbers = new HashSet<int>();
Random r = new Random();

//Метод генерации неповторяющегося числа
int GenerateUniqueNumber()
{
    while (true)
    {
        var n = r.Next(10, 100);
        if (!numbers.Contains(n))
        {
            numbers.Add(n);
            return n;
        }
    }
}
// Метод создает массив 
int[,,] CreateArray(int x, int y, int z)
{
    int[,,] outArray = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {

                outArray[i, j, k] = GenerateUniqueNumber();
            }

        }
    }
    return outArray;
}
// Метод печатает массив
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})" + " ");
            }
        }
    }
}

PrintArray(CreateArray(2, 2, 2));

