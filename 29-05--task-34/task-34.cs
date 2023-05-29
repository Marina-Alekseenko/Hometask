// // Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GenerateArray()
{
    int[] array = new int[5];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
int[] array = GenerateArray();

int sumEven = 0;
for (int i = 0; i < array.Length; i++)
{
    
    if (array[i] % 2 == 0)
    {
        sumEven = sumEven + array[i];
    }
}
Console.Write($"Массив: ");
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Сумма четных чисел - {sumEven}");
