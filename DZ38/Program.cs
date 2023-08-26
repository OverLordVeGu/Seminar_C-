// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear();

double[] FillArray (int size) // Метод для заполнения массива случайными трех значными числами
{
    double [] array = new double [size];  
    Random random = new Random ();
    for (int i = 0; i < size; i++)  
    {
        array [i] = Math.Round(random.NextDouble (), 2); // внесение рандомного вещественного числа с округлением до 2го знака после запятой
    }
    return array;
}

double FindMaxElement (double [] array) // Метод для нахождения макскимального элемента массива
{
    double maxElement = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > maxElement)
        {
            maxElement = array [i];
        }
    }
    return maxElement;
}

double FindMinElement (double [] array) // Метод для нахождения минимального элемента массива
{
    double minElement = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] < minElement)
        {
            minElement = array [i];
        }
    }
    return minElement;
}

double [] array = FillArray (6);
Console.WriteLine (string.Join (" ", array));
Console.WriteLine ($"Максимальный элемент массива = {FindMaxElement(array)}");
Console.WriteLine ($"Минимальный элемент массива = {FindMinElement(array)}");
Console.WriteLine ($"Разница между максимальным и минимальным элементом массива = {Math.Round(FindMaxElement(array) - FindMinElement(array), 2)}");