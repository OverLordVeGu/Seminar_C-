Console.Clear ();
Console.Write ("Введи число №1: ");
int num1 = int.Parse (Console.ReadLine ());
Console.Write ("Введи число №2: ");
int num2 = int.Parse (Console.ReadLine ());

// double Stepen (int num1, int num2) {
//     double result = Math.Pow (num1, num2);
//     return result;
// }

double Stepen (int num1, int num2) {
    int result = num1;
    for (int i = 1; i < num2; i++) {
        result *= num1;
    }
    return result;
}

double result = Stepen (num1, num2);
Console.Write ($"Если число {num1} возвести в {num2} результат = {result}");


