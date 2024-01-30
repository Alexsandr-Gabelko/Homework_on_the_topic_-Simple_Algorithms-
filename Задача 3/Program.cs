/*    Напишите программу, которая принимает
на вход целое число из отрезка [10, 99] и показывает
наибольшую цифру числа.                  */

Console.Write("Введите число: ");
string number = Console.ReadLine()!;
int int_number = int.Parse(number);

int number1 = int_number / 10;
int number2 = int_number % 10;

if (number1 > number2)
    Console.Write(number1); 
else
    Console.Write(number2);