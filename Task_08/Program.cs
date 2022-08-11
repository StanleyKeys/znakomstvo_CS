// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int number = 0;

Console.Write("Введите число: ");
number = int.Parse(Console.ReadLine());

for (int i = 1; i < number; i++)
   if (i / 2 * 2 == i)
    Console.WriteLine(i);
   



