string? number = Console.ReadLine();
int n = int.Parse(number);
Console.WriteLine(n);
int i = 1;
while (n > 1)
{
    int result = i * 2;
    n = n - 2;
    i++;
    Console.Write(result + " ");
}