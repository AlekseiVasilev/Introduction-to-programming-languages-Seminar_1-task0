//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

// int columns = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty));

Console.Write("Введите два числа: ");
int number1 = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty));
int number2 = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty));
if(number1 > number2)
{
Console.WriteLine($"Число {number1} больше числа {number2}");
}
else
{
Console.WriteLine($"Число {number2} больше числа {number1}");
}
