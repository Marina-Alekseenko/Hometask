// //Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Сколько цифр хотите задать?");
int length = Convert.ToInt32(Console.ReadLine());
int[] GetNumbers(int length)
{
    int[] numbers = new int[length];
    for (int i = 0; i < length; i++)
    {
    Console.Write($"введите {i+1} число - ");
    int n = Convert.ToInt32(Console.ReadLine());
    numbers[i] = n;
    }
    return numbers;
}
int SearchPositiv(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) count = count + 1;
    }
    return count;
}
int[] numbers = GetNumbers(length);
int count = SearchPositiv(numbers);
Console.WriteLine($"Количество положительных: {count}");
