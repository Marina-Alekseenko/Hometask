// // Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

void PrintArray(double[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i, j] = new Random().NextDouble();
            if (i % 2 == 0) array2d[i,j] = array2d[i,j] * 10;
            else array2d[i,j] = array2d[i,j] * -10;
            array2d[i,j] = Math.Round(array2d[i,j], 1);
            Console.Write(array2d[i, j] + "             ");
        }
        Console.WriteLine();
    }
}
double[,] array2d = new double[m, n];
PrintArray(array2d);