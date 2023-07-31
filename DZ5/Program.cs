Console.Clear();
Console.Write("Введите число: ");
string NumberA = Console.ReadLine();
int num = int.Parse(NumberA);
int result = (num%100)/10;
Console.WriteLine ($"Второе число {result}");
