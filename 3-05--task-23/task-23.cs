// // Напишите программу, которая принимает на вход число (n) 
// и выдаёт таблицу кубов чисел от 1 до N.
// (сделала, чтобы работало и для отрицательных чисел)

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// -5 -> 

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
if (n > 0)
{
    while (a <= n)
    {
        var result = Math.Pow((a), 3);
        Console.Write($"{result}  ");
        a++;
    }
}
else
{
    while (a >= n)
    {
        var result = Math.Pow((a), 3);
        Console.Write($"{result}  ");
        a--;
    }
}