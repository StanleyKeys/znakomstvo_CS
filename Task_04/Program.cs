// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


int number1 = 0;
int number2 = 0;
int number3 = 0;

int max = 0;

Console.Write("Введите первое число: ");
number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
number3 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    max = number1;
}

else 
{
    max = number2;
}

if (number3 > max)
{
    max = number3;
}
Console.WriteLine($"Самое большое число является: {max} ");