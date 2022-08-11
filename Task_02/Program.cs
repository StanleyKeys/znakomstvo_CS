// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int number1 = 0;
int number2 = 0;

Console.Write("Введите первое число: ");
number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.Write($"Число {number1} больше числа {number2}");

}
else 
{
    Console.Write($"Число {number2} больше числа {number1}");
}