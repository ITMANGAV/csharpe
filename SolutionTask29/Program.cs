string readStr()
{
    Console.Write("Введите имена: ");
    string? str = Console.ReadLine();
    return str;
}

void solution(string stroka)
{
    string[] names = stroka.Split(new string[] { "," }, StringSplitOptions.None);
    int count = names.Length;
    int number = new Random().Next(0, count);
    Console.WriteLine($"Выиграл -> {names[number]}");
}

string stroka = readStr();
solution(stroka);