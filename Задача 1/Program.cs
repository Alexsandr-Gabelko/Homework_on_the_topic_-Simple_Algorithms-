/* Задача 1: Напишите программу, которая принимает
на вход число и проверяет, кратно ли оно
одновременно 7 и 23 */

Console.Write("Введите число: ");
string number = Console.ReadLine()!;
int int_number = int.Parse(number);

if (int_number % 7 == 0 && int_number % 23 == 0)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");


