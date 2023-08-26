// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear ();

int [] FillArray (int size, int minValue, int maxValue) // Метод для заполнения массива случайными трех значными числами
{
    int [] array = new int [size];  
    Random random = new Random ();
    for (int i = 0; i < size; i++)  
    {
        array [i] = random.Next (minValue, maxValue);
    }
    return array;
}

int SumOddElements (int [] array) // Метод для подсчета суммы элементов массива стоящих на нечётных позициях
{
    int sum = 0;
    for (int i = 1; i < array.Length; i +=2 )
    {
        sum = sum + array [i];
    }
    return sum;
}

int [] array = FillArray (4, 1, 50);
Console.WriteLine (string.Join (" ", array));
Console.WriteLine ($"Сумма элементов на нечетных позициях = {SumOddElements (array)}");
