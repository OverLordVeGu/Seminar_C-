Console.Clear ();
Console.Write ("Введите число ");
string Number1 = Console.ReadLine ();
int num1 = int.Parse (Number1);
int start = 1;
while (start <= num1) {
    if (start%2==0) {
        Console.Write (start);
        Console.Write(", ");
    }
    start = start + 1;
       
}

