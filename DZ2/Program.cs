Console.Clear ();
Console.WriteLine ("Введите число №1: ");
string Number1 = Console.ReadLine ();
int num1 = int.Parse (Number1);
Console.WriteLine ("Введите число №2: ");
string Number2 = Console.ReadLine ();
int num2 = int.Parse (Number2);
Console.WriteLine ("Введите число №3: ");
string Number3 = Console.ReadLine ();
int num3 = int.Parse (Number3);
int max = 0;
if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write ("max = ");
Console.WriteLine (max);