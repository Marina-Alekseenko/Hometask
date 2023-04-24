//  Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

string n = Console.ReadLine();
int n1 = Convert.ToInt32(n);
int X = 2;
if (n1 >= X)
{
    while (n1 >= X) 
    {
    Console.WriteLine(X);
    X = X + 2;
    }
}
else
{
    Console.WriteLine("Введены некорректные данные");
}