// Метод создает массив вещественных чисел
double[] CreateArray()
{
    Console.Write("Введите число, размер массива: ");
    string? number = Console.ReadLine();
    int num = int.Parse(number);
    double[] arr = new double[num];
    Random random = new Random();
    for (int i = 0; i < num; i++)
    {
        arr[i] = random.NextDouble() * 100;
    }
    return arr;
}
// Метод распечатывает массив
void PrintArr(double[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        Console.Write("{0,6:F3} ", arr1[i]);
    }
}
// Метод сортирует массив вставками
double[] InsertionSort(double[] array)
{
    double[] result = new double[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        int j = i;
        while (j > 0 && result[j - 1] > array[i])
        {
            result[j] = result[j - 1];
            j--;
        }
        result[j] = array[i];
    }
    return result;
}

double[] newArray = CreateArray();
PrintArr(newArray);
double[] sortArray = InsertionSort(newArray);
Console.WriteLine();
PrintArr(sortArray);
double rez = sortArray[sortArray.Length - 1] - sortArray[0];
Console.WriteLine();
Console.WriteLine($"Разница между мин и мак значениями = {rez}");
