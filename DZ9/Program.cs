Console.Clear( );
Console.WriteLine("Введите координату x первой точки");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки");
int z2 = int.Parse(Console.ReadLine());

double Line = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2)+ Math.Pow((z2 - z1),2));
Console.WriteLine($"Длина отрезка {Line}");

