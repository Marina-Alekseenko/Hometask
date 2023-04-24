// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


string a = Console.ReadLine();
string b = Console.ReadLine();

int a1 = Convert.ToInt32(a);
int b1 = Convert.ToInt32(b);

if (b1 < a1)
{
    Console.WriteLine("Большее число - " + a1);
    Console.WriteLine("Меньшее число - " + b1);
}
else
{
    Console.WriteLine("Большее число - " + b1);
    Console.WriteLine("Меньшее число - " + a1);
}
