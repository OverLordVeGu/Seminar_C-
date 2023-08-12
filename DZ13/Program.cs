Console.Clear();
int [] FillArray ()
{
    int [] array = new int [8];
    Random random = new Random ();
    for (int i = 0; i < 8; i++) 
    {
        array [i] = random.Next (1, 100);
    }
    return array;
}

void PrintArray (int [] array)
{
    Console.Write ("[");
    for (int i = 0; i < 7; i++)
    {
        Console.Write ($"{array [i]}, ");
    }
    Console.Write ($"{array[7]}");
    Console.WriteLine ("]");
}

int [] array = FillArray ();
PrintArray (array);