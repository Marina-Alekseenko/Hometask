//  Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число");

int A = Convert.ToInt32(Console.ReadLine());

int Sum(int X)
{
    int res = 0;
    while (X > 0) 
    {
        int N = X % 10;
         res = res + N;
         X = X / 10;
    }
    return res;
}
int amount = Sum(A);
Console.WriteLine($"Сумма всех цифр {amount}");