// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write($"{num}");

void Count(int sum = 0)
{
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num /10 ;
    }
    Console.Write($" -> {sum}");
}
Count(0);

            
