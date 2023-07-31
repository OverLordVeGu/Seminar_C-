Console.Clear();
Console.Write("Введите число: ");
string NumberA = Console.ReadLine();
int num = int.Parse(NumberA);
int result = (num%10)%10-num;
if (num < 100) {
    Console.WriteLine("Третьей цифры нет");
}
else {
    Console.WriteLine ($"Третья цифра {result}");
}
