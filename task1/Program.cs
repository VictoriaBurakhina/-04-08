﻿//Напишите программу, которая на вход принимает два числа и проверяет, является ли втрое число квадратом первого.
//a = 5; b = 25 -> да 
//a = 2 b = 10 -> нет 
//a = 9; b = -3 -> нет 
//a = -3 b = 9 -> да

int userNumberFirst =new int ();
int userNumberSecond = new int ();
Console.WriteLine("введите первое число, ");
userNumberFirst = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("введите второе число, ");
userNumberSecond = Convert.ToInt32 (Console.ReadLine ());
if (userNumberFirst * userNumberFirst == userNumberSecond)
{
    Console.WriteLine ($"число {userNumberSecond} является квадратом числа {userNumberFirst}");
}
else
{
    Console.WriteLine ($"число {userNumberSecond} не является квадратом числа {userNumberFirst}");
}