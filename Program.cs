﻿//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите два числа: ");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
if(number1 > number2)
{
Console.WriteLine($"Число {number1} больше числа {number2}");
}
else
{
Console.WriteLine($"Число {number2} больше числа {number1}");
}
