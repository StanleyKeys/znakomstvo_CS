//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");

int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
  int index1 = 1;
  int length = cube.Length;
  while (index1 < length)
  {
    cube[index1] = Convert.ToInt32(Math.Pow(index1, 3));
    index1++;
  }
}

void PrintArray(int[] coll)
{
  int count = coll.Length;
  int index2 = 1;
  while(index2 < count)
  {
    Console.Write(coll[index2] + " ");
    index2++;
  }
} 

int[] array = new int[cube + 1];

Console.WriteLine($"\nТаблица кубов чисел от 1 до {cube}:");
Cube(array);
PrintArray(array);
Console.WriteLine();

