﻿// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
//2 -> " -2, -1, 0, 1, 2"

int number = new int ();
Console.WriteLine ("Введите число, ");
number = Convert.ToInt32 (Console.ReadLine ());
int minusNumber = 0-number;

while (minusNumber<=number){
Console.WriteLine (minusNumber);
minusNumber++;
}
