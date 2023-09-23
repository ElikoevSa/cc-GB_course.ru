// Напишите программу, которая на вход принимает число и 
// выдает его квадрат (число умноженное 
// на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

//Console.WriteLine("Введите число");
//int num =Convert.ToInt32(Console.ReadLine());

//int num2= num*num;
//Console.WriteLine(num2);////

// Задача №1. Напишите программу, которая на вход принимает
//  два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.WriteLine("Введите число");
int num1 =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num2 =Convert.ToInt32(Console.ReadLine());

if(num1==num2*num2)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}