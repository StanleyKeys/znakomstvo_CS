// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int a = 0;
int b = 0;

Console.WriteLine("Введите трехзначное число: ");

 a = int.Parse(Console.ReadLine());

if (a < 99)                              // знак || означает что if будет проверять выполнение условий (либо левый либо правый.)
{
    Console.WriteLine($"\nВы ввели неверное число");
    return;
}

while (a > 999)
 {
    a = a / 10;
 }

b = a % 10;

Console.WriteLine($"\nТретье число = {b}");


Console.WriteLine($"\n End of Program");