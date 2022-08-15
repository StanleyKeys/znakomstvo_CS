// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int number)
{
    
    int count = Convert.ToString(number).Length;
    int temp = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      temp = number - number % 10;
      result = result + (number - temp);
      number = number / 10;
    }
    return result;
}

int sumNumber = SumNumber(number);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);