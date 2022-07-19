Console.WriteLine("Введите данные точек в формате A(3,6,8);B(2,1,-7)");
string? str = Console.ReadLine();
string a = str.Substring(0, str.IndexOf(";"));
string b = str.Substring((str.IndexOf(";") + 1));

string a1 = a.Substring((str.IndexOf("(") + 1), (str.IndexOf(",") - str.IndexOf("(") - 1));
string bak = a.Substring((str.IndexOf(",") + 1));
string a2 = bak.Substring(0, bak.IndexOf(","));
string bak1 = bak.Substring((bak.IndexOf(",") + 1));
//Console.WriteLine($"bak={bak} bak1={bak1}");
string a3 = bak1.Substring(0, bak1.IndexOf(")"));

string b1 = b.Substring((b.IndexOf("(") + 1), (b.IndexOf(",") - b.IndexOf("(") - 1));
string bakb = b.Substring((b.IndexOf(",") + 1));
string b2 = bakb.Substring(0, bakb.IndexOf(","));
string bakb1 = bakb.Substring((bakb.IndexOf(",") + 1));
//Console.WriteLine($"bakb={bakb} bakb1={bakb1}");
string b3 = bakb1.Substring(0, bakb1.IndexOf(")"));

int x1 = int.Parse(a1);
int y1 = int.Parse(a2);
int z1 = int.Parse(a3);

int x2 = int.Parse(b1);
int y2 = int.Parse(b2);
int z2 = int.Parse(b3);

double rezultat = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));
Console.WriteLine($"Расстояние между {a} и  {b} -> {rezultat}");
//Console.WriteLine($"{a1} | {a2} | {a3}  ;  {b1} | {b2} | {b3}");
