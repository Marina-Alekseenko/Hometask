// // Задача 50. Напишите программу, которая на вход принимает значение элемента 
// в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i, j] = new Random().Next(1, 4);
            Console.Write(array2d[i, j] + "    ");
        }
        Console.WriteLine();
    }
}

void SearchElem(int n, int[,] array2d) 
{
    int count = 0;
for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            if (array2d[i, j] == n) 
            {
                Console.WriteLine($"Строка {i}, столбец {j}");
                count = count + 1;
            }
        }
    }
if (count == 0 ) Console.WriteLine($"Числа {n} нет в массиве");  
}
int[,] array2d = new int[m, n];
PrintArray(array2d);
Console.WriteLine("Введите число для проверки");
int x = Convert.ToInt32(Console.ReadLine());
SearchElem(x, array2d);
