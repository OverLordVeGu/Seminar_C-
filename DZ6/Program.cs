Console.Clear();
Console.Write("Введите число: ");
string NumberA = Console.ReadLine();
int num = int.Parse(NumberA);
int result = 0;
if (num < 100) {
    Console.WriteLine("Третьей цифры нет");
}
else if (num>99 && num<1000)
{
    result = num%10;
    Console.WriteLine ($"Третья цифра {result}");
}
else if (num>999 && num<10000)
{
    result = num%100/10;
    Console.WriteLine ($"Третья цифра {result}");
}
else if (num>9999 && num<100000)
{
    result = num%1000/100;
    Console.WriteLine ($"Третья цифра {result}");
}
else if (num>99999 && num<1000000)
{
    result = num%10000/1000;
    Console.WriteLine ($"Третья цифра {result}");
}
else if (num>999999 && num<10000000)
{
    result = num%100000/10000;
    Console.WriteLine ($"Третья цифра {result}");
}