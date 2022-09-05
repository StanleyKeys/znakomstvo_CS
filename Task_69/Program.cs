/* 
    Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
    A = 3; B = 5 -> 243 (3⁵)
    A = 2; B = 3 -> 8
*/

Console.Clear();

Console.Write("Введите число A: ");
    int numberA = Convert.ToInt32(Console.ReadLine());

  Console.Write("Введите число B: ");
    int numberB = Convert.ToInt32(Console.ReadLine());

int Exponent(int numberA, int numberB)
{
  int result = 1;

  for (int i = 1; i <= numberB; i++)
  {
        result = result * numberA;
  }
  return result;
}

  int answer = Exponent(numberA, numberB);
  Console.WriteLine();
  Console.WriteLine("Ответ: " + answer);
