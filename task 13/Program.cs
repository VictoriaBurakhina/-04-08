//Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да

int number = new int ();
Console.WriteLine ("Введите число");
number=Convert.ToInt32(Console.ReadLine());
int DevisionOnSeven=number%7;
int DevisionOn23=number%23;
if (DevisionOnSeven ==0 && DevisionOn23==0)
{
    Console.WriteLine ($"да");
}
else
{
    Console.WriteLine ($"нет");
}