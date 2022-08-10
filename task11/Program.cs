// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

Console.WriteLine ("Введите трехзначное число");
int GetRandomNumber ()
{
    int result = new Random().Next (100,999);
    return result;
}
int num = GetRandomNumber ();

int FirstNumber= num/100;
int SecondNumber = num%10;
Console.WriteLine ($"{num} - {FirstNumber}{SecondNumber}");