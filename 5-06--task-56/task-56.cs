// // Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

void CreateArray(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i, j] = new Random().Next(1, 10);
            Console.Write(array2d[i, j] + "    ");
        }
        Console.WriteLine();
    }
}

void SearchLine(int[,] array2d)
{  
    int sum = 0;
    int minSum = 0;
    int minPosition = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            if (i == 0)
            {
                sum = sum + array2d[i, j];
                minSum = minSum + array2d[i, j];
            }
            else sum = sum + array2d[i, j];
        }
             if (sum < minSum)
             {
                minSum = sum;
                minPosition = i;
             }
             sum = 0;
    } 
    Console.WriteLine($"{minPosition+1} строка имеет наименьшую сумму");
} 

int[,] array2d = new int[m, n];
if (n > m || m > n)
{
    Console.WriteLine("Исходный массив:");
    CreateArray(array2d);
    SearchLine(array2d);
}
else
{
    Console.WriteLine("Некорректный ввод. Задайте прямоуголный двумерный массив");
}
