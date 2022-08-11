// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int number1 = 0;

Console.Write("Введите число: ");
number1 = int.Parse(Console.ReadLine());

if (number1 / 2 * 2 ==number1)
{
    Console.Write("Число является Чётным");
}

else 
{
    Console.Write("Число является Нёчетным");
}
