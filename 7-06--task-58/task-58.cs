// //Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] ArrayMultiplication(int[,] array1, int[,] array2)
{
int[,] arrResult = new int[array1.GetLength(0), array2.GetLength(1)];

        for (var i = 0; i < array1.GetLength(0); i++)
        {
            for (var j = 0; j < array2.GetLength(1); j++)
            {
               arrResult[i, j] = 0;

                for (var k = 0; k < array1.GetLength(1); k++)
                {
                    arrResult[i, j] =  arrResult[i, j] + array1[i, k] * array2[k, j];
                }
            }
        }

        return arrResult;
}
 void PrintArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + "    ");   
} 

int[,] array1 = new int[2, 2];
Console.WriteLine("Первая мартица:");
CreateArray(array1);
int[,] array2 = new int[2, 2];
Console.WriteLine("Вторая матрица:");
CreateArray(array2);

int[,] arrResult = ArrayMultiplication(array1, array2);
Console.WriteLine("Результат произведения матриц:");
PrintArray(arrResult);