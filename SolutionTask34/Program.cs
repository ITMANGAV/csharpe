// Метод создает массив, запрашиваемой длины.
int[] CreateArray()
{
    Console.Write("Введите число, размер массива: ");
    string? number = Console.ReadLine();
    int num = int.Parse(number);
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}
// Метод распечатывает массив
void PrintArr(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        Console.Write(arr1[i] + " ");
    }
}
// Метод подсчитыает четные числа в массиве
int EvenNumbers(int[] arr)
{
    int countEven = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            countEven++;
        }

    }
    return countEven;
}
int[] arrayTask = CreateArray();
PrintArr(arrayTask);
int digit = EvenNumbers(arrayTask);
Console.WriteLine();
Console.WriteLine($"В этом массиве четных чисел = {digit}");