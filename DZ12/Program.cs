Console.Clear ();
int EnterNumber ()
{
    Console.Write ("Введите число ");
    int number = int.Parse (Console.ReadLine ());
    return number;
}

int Sum (int number)
{
    int result = 0;
        for (int i = 0; i < 100; i++)
    {
        int OneNumber = number%10;
        number = number/10;
        result += OneNumber;
    }
    return result;
}
int StrNumbers = EnterNumber ();
int GetSum = Sum (StrNumbers);
Console.WriteLine (GetSum);

