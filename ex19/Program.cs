// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine()!);

if (number >= 10000 && number <= 99999)
{
    if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10)
    {
        System.Console.WriteLine("Введенное число является палиндромом");
    }
    else
    {
        System.Console.WriteLine("Введенное число не является палиндромом");
    }
}
else
    System.Console.WriteLine("Вы ввели не пятизначное число");

//решение через строку

// string numberStr = number.ToString();
// if (numberStr[0] == numberStr[4] && numberStr[1] == numberStr[3])
// {
//     System.Console.WriteLine("Введенное число является палиндромом");
// }
// else
// {
//     System.Console.WriteLine("Введенное число не является палиндромом");
// }
