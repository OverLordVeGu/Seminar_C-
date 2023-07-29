Console.Clear ();
Console.WriteLine ("Введите число ");
string Number1 = Console.ReadLine ();
int num1 = int.Parse (Number1);

if (num1%2==0) {
    Console.WriteLine ("Ваше число чётное");
} 
else {
    Console.WriteLine ("Выше число нечётное");
}
