// // Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] GenerateArray()
{
    int[] array = new int[6];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int[] array = GenerateArray();

int sumOddElements = 0;
for (int i = 0; i < array.Length; i++)
{
    
    if (i % 2 > 0)
    {
        sumOddElements = sumOddElements + array[i];
    }
}
Console.Write($"Массив: ");
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Сумма элементов на нечетных позициях - {sumOddElements}");
