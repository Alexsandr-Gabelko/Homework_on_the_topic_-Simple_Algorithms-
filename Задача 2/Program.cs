/*    Напишите программу, которая принимает
на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
0 и выдаёт номер координатной четверти плоскости,
в которой находится эта точка.                  */

Console.WriteLine("Введите координаты точки (X и Y), причём X и Y не равны 0 ");

Console.Write("Введите координату Х : ");
string X = Console.ReadLine()!;
int int_X = int.Parse(X);

Console.Write("Введите координату Y : ");
string Y = Console.ReadLine()!;
int int_Y = int.Parse(Y);

if (int_X > 0 && int_Y > 0)
        Console.WriteLine("1"); 
    else if (int_X < 0 && int_Y > 0)
        Console.WriteLine("2"); 
    else if (int_X < 0 && int_Y < 0)
         Console.WriteLine("3"); 
else 
    Console.WriteLine("4"); 
