// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");

string userEnter = Console.ReadLine();

void Palindrom(string userEnter)
{
  if (userEnter[0] == userEnter[4] || userEnter[1] == userEnter[3])
  {
    Console.WriteLine($"Ваше число - Палиндром.");
  }
  else
  {
    Console.WriteLine($"Ваше число - НЕ Палиндром.");
  }
}

if (userEnter.Length != 5)
{
    Console.WriteLine($"Вы ввели неверное число.");
    return;
}

Palindrom(userEnter);