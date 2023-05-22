// // Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int Mass()
{
int elementies = new Random().Next(0,9);
return elementies;
}
int[] massiv = new int[8];
for (int i = 0; i <= 7; i++)
{
    massiv[i] = Mass();
}
Console.WriteLine(String.Join(", ", massiv));