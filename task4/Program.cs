// 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	//456 -> 6
	//782 -> 2
	//918 -> 8

int number = new int ();
Console.WriteLine ("Введите положительное трехзначное число");
number = Convert.ToInt32 (Console.ReadLine());
if  (number<100|number<0){
    Console.WriteLine ("Вы ввели неверное число");
}
else {
   Console.WriteLine ($"Последняя цифра Вашего числа {number%10}"); 
}
