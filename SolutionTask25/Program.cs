string read()
{
    Console.WriteLine("Введите строку вычислений, например:  18 + 31 :");
    string? str = Console.ReadLine();
    return str;
}

void solution(string str)
{
    string number1 = str.Substring(0, str.IndexOf(" "));
    string number2 = str.Substring(str.IndexOf(" ") + 3);
    string action = str.Substring(str.IndexOf(" ") + 1, 1);
    //Console.WriteLine($"n1={number1}. n2={number2}. act={action}.");
    int num1 = int.Parse(number1);
    int num2 = int.Parse(number2);

    switch (action)
    {
        case "+":
            Console.WriteLine(num1 + num2);
            break;
        case "-":
            Console.WriteLine(num1 - num2);
            break;
        case "*":
            Console.WriteLine(num1 * num2);
            break;
        case "/":
            Console.WriteLine(num1 / num2);
            break;
        case "^":
            Console.WriteLine(Math.Pow(num1, num2));
            break;
        default:
            Console.WriteLine("Ошибка операции вычисления");
            break;
    }
}


solution(read());
