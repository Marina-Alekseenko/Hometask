// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void PrintArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + "           ");   
} 

void FillArray(string[] args, int n)
{      
       int[,] a = new int[n, n];
       int i =0;
       int j = 0;
       a[0,0] = 1;
       
      for ( ++j ; j<= n-1; j++) a[i,j] = a[i,j-1] +1;
       j=n-1; 
      for (++i; i<=n-1;i++) a[i,j] = a[i-1,j] +1;
      i=n-1;
      for (--j; j>=0; j--) a[i,j] = a[i,j+1] +1;
      j=0;
      for (--i; i>0;i--) a[i,j] = a[i+1,j] +1;
        n--;
        i++;
      
        for ( ++j ; j<=n-1; j++) a[i,j] = a[i,j-1] +1;
        j=n-1; 
        for (++i; i<=n-1;i++) a[i,j] = a[i-1,j] +1;
        i=n-1;
        for (--j; j>0; j--) a[i,j] = a[i,j+1] +1;
        j=0;
        for (--i; i>0;i--) a[i,j] = a[i+1,j] +1;
              
        PrintArray(a);
        Console.WriteLine();
}

 FillArray(args, 4);
