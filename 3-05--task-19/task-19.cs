// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите 5-значное число");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 10000 && n < 100000)
{
    int lastNumber = n % 100;
    int firstNumber = n / 1000;
    if (lastNumber % 10 == firstNumber / 10 && lastNumber / 10 == firstNumber % 10)
    {
        Console.WriteLine("палиндром");
    }
    else
    {
        Console.WriteLine("не палиндром");
    }
}
else
{
    Console.WriteLine("Некорректный ввод - число должно быть 5-значным");
}