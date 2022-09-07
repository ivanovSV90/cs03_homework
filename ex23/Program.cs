// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N");
int number = int.Parse(Console.ReadLine()!);


int[] degree = new int[number];

for (int i = 1; i <= number; i++)
{
    degree[i - 1] = Convert.ToInt32(Math.Pow(i, 3));
}

for (int i = 0; i < number; i++)
{
    Console.Write(degree[i]);
    if (i < number - 1)
        System.Console.Write(", ");
}