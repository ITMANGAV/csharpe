int number = new Random().Next(10, 100);
Console.Write(number);
int fNum = number / 10;
int sNum = number % 10;
if (fNum > sNum)
{
    Console.WriteLine(" -> " + fNum);
}
else
{
    Console.WriteLine(" -> " + sNum);
}

