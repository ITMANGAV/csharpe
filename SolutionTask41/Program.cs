Console.WriteLine("Введите последовательность чисел через запятую: ");
string? str = Console.ReadLine();
string[] data = str.Split(new string[] { "," }, StringSplitOptions.None);
int[] digits = new int[data.Length];
int i = 0;
foreach (string k in data)
{
    digits[i] = int.Parse(k);
    //Console.WriteLine(digits[i]);
    i++;
}

int More0(int[] arr)
{
    int p = 0;
    foreach (int j in arr)
    {
        if (j > 0) { p++; }
    }
    return p;
}

Console.WriteLine(More0(digits));