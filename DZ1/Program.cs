Console.Clear();
Console.Write("Введите число a: ");
string NumberA = Console.ReadLine ();
int a = int.Parse (NumberA);
Console.Write("Введите число b: ");
string NumberB = Console.ReadLine ();
int b = int.Parse (NumberB);
if (a > b) {
    Console.Write ("max ");
    Console.WriteLine (a);
    Console.Write ("min ");
    Console.WriteLine (b);
}
else {
    Console.Write ("max ");
    Console.WriteLine (b);
    Console.Write ("min ");
    Console.WriteLine (a); 
}