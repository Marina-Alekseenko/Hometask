// // Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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
            array2d[i, j] = new Random().Next(1, 10);
            Console.Write(array2d[i, j] + "    ");
        }
        Console.WriteLine();
    }
}

void Average(int[,] array) 
{ 
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
        sum = sum + array[i, j];
        }   
        double result = Math.Round(((double)sum / m),2);
        //double res = Convert.ToDouble(result);
        Console.WriteLine($"Среднее арифметическое {j+1} столбца: {result}");    
     
    }     
}   
int[,] array2d = new int[m, n];
PrintArray(array2d);
Average(array2d);