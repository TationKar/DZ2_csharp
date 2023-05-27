/* Задача 10: Напишите программу, которая принимает 
на вход  трёхзначное число и на выходе показывает 
вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */
Console.Clear();
Console.Write("Введите целое трехзначное число: ");
int threeDigit = int.Parse(Console.ReadLine()!);
int twoDigit = threeDigit % 100;
Console.WriteLine($"Tрехзначное число {threeDigit} - вторая цифра {twoDigit / 10}");
