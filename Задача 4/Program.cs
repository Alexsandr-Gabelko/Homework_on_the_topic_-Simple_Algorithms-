/*   Напишите программу, которая на вход
принимает натуральное число N, а на выходе
показывает его цифры через запятую.         */

Console.Write("Введите натуральное число: ");
string number = Console.ReadLine()!;
int int_number = int.Parse(number);

int index = 0;
int num = int_number;
int digit_number = 1;

while (int_number > 0)
{
    int_number = int_number / 10;
    index += 1;
    digit_number *= 10;
}
digit_number = digit_number / 10;


for (int i = 1; i < index; i++)
{
    Console.Write(num / digit_number);
    Console.Write(", ");
    num = num - num / digit_number * digit_number;
    digit_number /= 10;
}
Console.Write(num);
