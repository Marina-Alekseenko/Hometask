//Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44, 5, 78 -> 78
//22, 3, 9 -> 22

string f = Console.ReadLine();
string d = Console.ReadLine();
string g = Console.ReadLine();

int f1 = Convert.ToInt32(f);
int d1 = Convert.ToInt32(d);
int g1 = Convert.ToInt32(g);

int maximum = f1;
if (d1 > maximum) maximum = d1;
if (g1 > maximum) maximum = g1;

Console.WriteLine("Максимальное число - " + maximum);