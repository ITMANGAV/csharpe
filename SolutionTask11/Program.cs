int number = new Random().Next(100, 1000);
Console.Write(number);
int fNum = number / 100;
int sNum = number % 10;
Console.WriteLine(" -> " + fNum + sNum);

