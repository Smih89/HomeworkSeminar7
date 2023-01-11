// Задача 1. Напишите программу, 
// которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5, b = 7 -> max = 7
// a = 2, b =10 -> max = 10
// a =-9, b =-3 -> max = -3

int a = 5;
int b = 7;
int max = a;
int min = b;
if (b > max)
{
  max = b;
  min = a;
}
else
  max = a;
  min = b;
Console.WriteLine(max);
Console.WriteLine("max");
Console.WriteLine(min);
Console.WriteLine("min");


