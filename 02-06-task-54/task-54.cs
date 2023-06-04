// // Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortArray (int[,] array2d)
{
for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int k = 0; k < array2d.GetLength(1); k++)
    for (int p = k + 1; p < array2d.GetLength(1); p++)
            if (array2d[i, k] < array2d[i, p])
                {
                     int tmp = array2d[i, p];
                     array2d[i, p] = array2d[i, k];
                     array2d[i, k] = tmp;
                }
     
    }
          
}
        
 void PrintArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + "    ");   
}   

int[,] array2d = new int[m, n];
Console.WriteLine("Исходный массив:");
CreateArray(array2d);
Console.WriteLine("Отсортированный массив:");
SortArray(array2d);
PrintArray(array2d);