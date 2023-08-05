Console.Clear();
Console.WriteLine("Введите число ");
string num = Console.ReadLine();
int number = int.Parse(num);
int TenThousandPart = number/10000;
int LastPart = number%10;
int ThousandPart = (number/1000)%10;
int TenPart = (number%100)/10;
if (TenThousandPart == LastPart && ThousandPart == TenPart) {
    Console.WriteLine($"Ваше число {num} являеться палиндромом");
}
else {
    Console.WriteLine($"Ваше число {num} не являеться палиндромом");
}