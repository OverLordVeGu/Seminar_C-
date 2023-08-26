// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();

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
int EvenCount (int [] array)  // Метод для подсчета четных элементов в массиве
{
    int count = 0;
    // for (int i = 0; i < array.Length; i++) // Классический цикл for
    // {
    //     if (array [i] % 2 == 0)
    //     {
    //         count++;
    //     }
    // }
    foreach (int element in array) // Альтернативный цикл
    {
        if (element % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int [] array = FillArray (10, 100, 1000);
Console.WriteLine (string.Join (" ", array));
Console.WriteLine ($"Колличество положительных элементов в массиве = {EvenCount (array)}");
