//12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

int FirstNumber = new int ();
Console.WriteLine ("Введите 1 число");
FirstNumber = Convert.ToInt32(Console.ReadLine());
int SecondNumber = new int ();
Console.WriteLine ("Введите 2 число");
SecondNumber = Convert.ToInt32(Console.ReadLine());
int number = FirstNumber%SecondNumber;
if (number>0)
{
Console.WriteLine ($"Остаток от деления {FirstNumber} на {SecondNumber} = {number}");
}
else
{
    Console.WriteLine ($"Число {FirstNumber} кратно числу {SecondNumber}");
}