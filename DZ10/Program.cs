Console.Clear();
Console.Write("Enter the number MAN - ");
int Num = int.Parse(Console.ReadLine());
int start = 1;
while (start <= Num) {
    double b = Math.Pow (start, 3);
    Console.Write($"{b} ");
    start++;
}