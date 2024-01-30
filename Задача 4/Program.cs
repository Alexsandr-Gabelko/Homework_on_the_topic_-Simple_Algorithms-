/*   Напишите программу, которая на вход
принимает натуральное число N, а на выходе
показывает его цифры через запятую.         */

Console.Write("Введите число: ");
string number = Console.ReadLine()!;
int int_number = int.Parse(number);

int index = 0;
int num = int_number;

while (int_number > 0)
{
    int_number = int_number / 10;
    index += 1;
}

// Console.WriteLine(index);

int raz = 10;

for (int i = 2; i < index; i++)
{
    raz *= 10; 
}

//  Console.WriteLine(raz);

for (int i = 1; i < index; i++)
{
   Console.Write(num / raz);
   Console.Write(", ");
   num = num - num / raz * raz;
   raz /=10; 
}
Console.Write(num);
