// // Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int a, int b)
{
    int sum = 0;
    if (a == b) return sum + a;
    else return a + SumNumbers(a + 1, b);
}
Console.WriteLine(SumNumbers(a, b));

