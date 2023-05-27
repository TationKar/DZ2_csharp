/* Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
Console.Clear();
Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine()!);
if (num < 100)
    Console.WriteLine("третьей цифры нет");
else if (num < 1000 && num >= 100)
    Console.WriteLine($"Tретья цифра в числе {num} - {num % 10}");
int intermdt = num;
if (num > 999)
{
    while (num / 10 > 99)
    {
        num = num / 10;
    }
    Console.WriteLine($"Tретья цифра в числе {intermdt} - {num % 10}");
}