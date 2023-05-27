/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */
Console.Clear();
int dayNum = new Random().Next(1, 7);

if (dayNum == 6 || dayNum == 7)
    Console.WriteLine($"{dayNum} -> да");
else
    Console.WriteLine($"{dayNum} -> нет");
