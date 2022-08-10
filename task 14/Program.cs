//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого. 
//5, 25 -> да -4, 16 -> да 25, 5 -> да 8,9 -> нет


Console.WriteLine ("Введите первое число");
int FirstNumber=Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число");
int SecondNumber=Convert.ToInt32(Console.ReadLine());

if (FirstNumber*FirstNumber ==SecondNumber)
{
    Console.WriteLine ("да");
}
else
{
    Console.WriteLine ("нет");
}