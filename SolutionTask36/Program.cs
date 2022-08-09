
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
// Метод находит сумму нечетных чисел в массиве
int SumOddNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}
int[] arrayTask = CreateArray();
PrintArr(arrayTask);
int digit = SumOddNumbers(arrayTask);
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечетных позициях = {digit}");