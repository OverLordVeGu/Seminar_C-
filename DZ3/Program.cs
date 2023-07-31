Console.Clear ();
Console.WriteLine ("Введите число ");
string Number1 = Console.ReadLine ();
int num1 = int.Parse (Number1);

if (num1%2==0) {
    Console.WriteLine ($"Ваше число {num1} - чётное");
} 
else {
    Console.WriteLine ($"Ваше число {num1} - нечётное");
}
