﻿// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int a = Convert.ToInt32(Console.ReadLine());

if (a < 1 || a > 7)
{
    Console.WriteLine("Введены некорректные данные");
}
else    if (a >= 1 && a <= 5)
    {
        Console.WriteLine("будний день");
    }
    else
    {
        Console.WriteLine("выходной день");
    }