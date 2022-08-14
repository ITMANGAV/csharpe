Console.WriteLine("Введите параметры уровнений (b1 = 2, k1 = 5, b2 = 4, k2 = 9):");
string str = Console.ReadLine();
// Метод из строки создает массив чисел-параметров уравнений
double[] Data(string s)
{
    string[] data = s.Split(new string[] { "," }, StringSplitOptions.None);
    double[] digits = new double[4];
    int i = 0;
    foreach (string k in data)
    {
        string number = k.Substring(k.IndexOf("=") + 1);
        digits[i] = int.Parse(number);
        i++;
    }
    return digits;
}

//Метод принимает параметры уравнений и вычисляет X и Y
double[] SolutionX(double[] digs)
{
    double x = (digs[2] - digs[0]) / (digs[1] - digs[3]);
    double y = digs[1] * x + digs[0];
    double[] sol = { x, y };
    return sol;
}

// Метод печаетает ответный массив 
void PrintXY(double[] o)
{
    Console.WriteLine($"({o[0]};{o[1]})");
}

double[] digs = Data(str);
double[] otvet = SolutionX(digs);
PrintXY(otvet);