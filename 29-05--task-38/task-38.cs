// // Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// Диапазон [-10, 10]. Обратите внимание на вещественных чисел
// Для примера возьмём диапазон побольше. [3 7 22 2 78] -> 76


double[] GenerateArrayDouble()
{
    double[] array = new double[6];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();
        
        if (i % 2 == 0) array[i] = array[i] * -10;
        else
        {
            array[i] = array[i] * 10;
        }
        array[i] = Math.Round(array[i], 2);
    }
    return array;
    
}

double[] array = GenerateArrayDouble();
double minElement = array[0];
double maxElement = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (minElement > array[i]) minElement = array[i];
    if (maxElement < array[i]) maxElement = array[i];
}

double substractMaxMin = maxElement - minElement;

Console.Write($"Массив: ");
Console.WriteLine(String.Join(" | ", array));
Console.WriteLine($"Разница между максимальным и минимальным элементом: ({maxElement}) - ({minElement}) = {substractMaxMin}");