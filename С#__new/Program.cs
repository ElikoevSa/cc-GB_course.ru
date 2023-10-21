// Напишите программу, которая выводит случайное число
//  из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

//int num = new Random().Next(10,100);

 //Console.WriteLine(num);
 
//int num1= num/10;
//int num2= num %10;

//if(num1>num2)
//{
//    Console.WriteLine(num1);

//}
//else
//{
 //    Console.WriteLine(num2);
//}

// Напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

//int num = new Random().Next(100,1000);

//Console.WriteLine(num);
 
//int num1= num/100;
//int num2= num % 10;

//int result = num1*10+num2;

//Console.WriteLine(result);
// Напишите программу, которая будет принимать на вход 
// два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

//Console.WriteLine("Введите число");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите число");
//int num2 = Convert.ToInt32(Console.ReadLine());

//if (num1%num2==0)
//{
 //   Console.WriteLine("Кратно");
///}
//else
//{
 //    Console.WriteLine("не кратно, "+ num1%num2);
//}
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

//Console.WriteLine("Введите число");
//int num = Convert.ToInt32(Console.ReadLine());

//if ((num % 7==0) && (num % 23==0))   //  && - И     || - Или
//{
 //   Console.WriteLine("Да");
//}
//
//else
//{
//     Console.WriteLine("Нет");
//}
// Напишите программу, которая принимает на вход два числа и проверяет,
//  является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

///int num1 = new Random().Next(100,1000);
//Console.WriteLine(num1);
//int num2 = new Random().Next(100,1000);
//Console.WriteLine(num2);
// int num1=5;
// int num2= 25;

//if(num1==num2*num2 || num2==num1*num1)
//{
//    Console.WriteLine("Да");
//}
//else
//{
//    Console.WriteLine("Нет");
//}
// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите число");
// int X = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int Y = Convert.ToInt32(Console.ReadLine());

//if(X>0 && Y>0)
//{
//    Console.WriteLine("1");
//}
//else if(X<0 && Y>0)
///{
///     Console.WriteLine("2");
//}
//else if(X<0 && Y<0)
//{
 //    Console.WriteLine("3");
//}
//else
//{
//    Console.WriteLine("4");
//}
// Напишите программу, которая по заданному номеру четверти, показывает
//  диапазон возможных координат
//  точек в этой четверти (x и y).

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num==1)
// {
//     Console.WriteLine("X>0 и Y >0");
// }
// else if(num==2)
// {
//      Console.WriteLine("X<0 && Y>0");
// }
// else if(num==3)
// {
//      Console.WriteLine("X<0 && Y<0");
// }
// else if(num==4)
// {
//     Console.WriteLine("X>0 && Y<0");
// }
// else
// {
//      Console.WriteLine("Нет такой четверти");
// }
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


// int n =49;
// double result= Math.Sqrt(48);

// double res= Math.Pow(-3,3);
// System.Console.WriteLine(res);

// Console.WriteLine("Введите число");
// int x1= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int y1= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int x2= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int y2= Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x1-x2,2)+ Math.Pow(y1-y2,2));

// Console.WriteLine(d);
// Напишите программу, которая принимает на вход число (N) и
//  выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите число");
// int num= Convert.ToInt32(Console.ReadLine());

// int i = 1;

//  while(i<=num)
//  {
//     Console.WriteLine(Math.Pow(i,2));
//     i=i+1;
//  }



// Console.WriteLine("Введите число");
// int num= Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i<=num; i++)
// {
//     Console.WriteLine(Math.Pow(i,2));
// }
// Задача 24: Напишите программу, которая принимает на вход
//  число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// тип возвращаемого значения( int/sting) + Название + ()


// Console.WriteLine("Введите число");
// int num= Convert.ToInt32(Console.ReadLine());

// int GetSunNum()
// {
//     int i =1;
//     int sum=0;

//     while(i<=num)
//     {
//         sum= sum+i;
//         i++;
//     }

//     return sum;
// }

// int result = GetSunNum();
// System.Console.WriteLine(result);
// Задача 28: Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.WriteLine("Введите число");
// int num= Convert.ToInt32(Console.ReadLine());

// int GetSumNum()
// {

//     int i = 1;
//     int result = 1;

//     while(i<=num)
//     {
//         result= result * i;
//         i++;
//     }

//     return result;
// }


// System.Console.WriteLine(GetSumNum());
// Задача 30: Напишите программу, которая выводит массив
//  из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];

// GetArray();

// void GetArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,2);
//         System.Console.Write(array[i]+ " | ");
//     }
// }
// Задача 40: Напишите программу, которая принимает на вход
//  три числа и проверяет, может ли существовать треугольник
//   с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон
// int[] array = new int[6];
// for (int i = 0; i < array.Length; i++)
// {
//   array[i]= new Random().Next(-1,3);
//   System.Console.Write(array[i]+ " ");
// }



// Console.WriteLine("Введите число");
// int num1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num3 = int.Parse(Console.ReadLine());

// if(num1<num2+num3 && num2<num1+num3 && num3<num1+num2)   
// {
//   System.Console.WriteLine("Может");
// }
// else
// {
//   System.Console.WriteLine("Не может");
// }

// Задача 42: Напишите программу, которая будет преобразовывать
//  десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Console.WriteLine("Введите число");
// int num1 = int.Parse(Console.ReadLine());

// string result ="";

// while(num1>0)
// {
//   result = num1%2 + result;
//   num1= num1/2;
// }

// System.Console.WriteLine(result);
// Задача 44: Не используя рекурсию, выведите первые N 
// чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// int first = 0;
// int second = 1;
 
// System.Console.Write(first+ ", "+ second+ ", ");

// for (int i = 2; i < num; i++)
// {
//   int nextNum= first+second;
//   System.Console.Write(nextNum+ ", ");

//   first=second;
//   second= nextNum;
// }

// Задача 39: Напишите программу, которая перевернёт
//  одномерный массив (последний элемент будет на первом 
//  месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int[] array = new int[6];

// for (int i = 0; i < array.Length; i++)
// {
//   array[i]= new Random().Next(-1,10);
//   System.Console.Write(array[i]+ " ");
// }

// for (int i = 0; i < array.Length /2; i++)
// {
//   int temp=0;
//   temp= array[i];
//   array[i]= array[array.Length-1-i];
//   array[array.Length-1-i]= temp;
// }
// System.Console.WriteLine();
// for (int i = 0; i < array.Length; i++)
// {
//   System.Console.Write(array[i]+ " ");
// }
// Задача 46: Задайте двумерный массив размером
//  m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19вщ
// 5 -2 33 -2
// // 77 3 8 1

// Console.WriteLine("Введите размероность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размероность массива");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int[rows,columns];   // Строчек + столбцы

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0,10);
//         Console.Write(array[i,j]+ " ");
//     }
//     Console.WriteLine();
// }
// Задача 48: Задайте двумерный массив размера
//  m на n, каждый элемент в массиве находится 
//  по формуле: Aₘₙ = m+n. Выведите полученный
//   массив на экран.
// m = 3, n = 4.
// 0 1 2 3 
// 1 2 3 4
// 2 3 4 5   2

// Console.WriteLine("Введите размерность массива:");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размерность массива:");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] arr = new int[rows, columns];

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         arr[i, j] = i + j;
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Задача 49: Задайте двумерный массив. Найдите 
// элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 0 1 2 3 

// 1 4 7 2    0
// 5 9 2 3    1
// 8 4 2 4    2

// Console.WriteLine("Введите размероность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размероность массива");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int[rows,columns];   // Строчек + столбцы

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0,10);
//         Console.Write(array[i,j]+ " ");
//     }
//     Console.WriteLine();
// }
//  Console.WriteLine();

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if(i%2 ==0 && j%2==0)
//         {
//             array[i,j] = array[i,j]* array[i,j];
//         }
//         Console.Write(array[i,j]+ " ");
//     }
//     Console.WriteLine();
// }

// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся 
// на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12



// Console.WriteLine("Введите размероность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размероность массива");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int[rows,columns];   // Строчек + столбцы

// int sum=0;

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0,10);
//         Console.Write(array[i,j]+ " ");

//         if(i==j)
//         {
//             sum= sum + array[i,j];
//         }
//     }
//     Console.WriteLine();
// }

//  Console.WriteLine("Сумма элементов на главной диагонали = "+ sum);
// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// Console.WriteLine("Введите размероность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размероность массива");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,]  GetArray (int m, int n)
// {
//     int [,] array = new int[m,n]; 

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,10);
//         }
//     }

//     return array;
// }

// void PrintArray(int[,] inputArray)    
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
//             Console.Write(inputArray[i,j]);
//         }
//         Console.WriteLine();
//     }
// }

// void ChangeArray(int[,] matrix)
// {
//     int rowsCount = matrix.GetLength(0)-1;

//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         int temp = matrix[0,i];
//         matrix[0,i] =matrix[rowsCount,i];
//         matrix[rowsCount,i]= temp;
//     }
// }

// int[,] array2= GetArray(rows,columns);
// PrintArray(array2);
// ChangeArray(array2);
// System.Console.WriteLine();
// PrintArray(array2);
// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет
//  строки на столбцы. В случае, если это невозможно, программа должна 
//  вывести сообщение для пользователя.

// Console.WriteLine("Введите размероность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int[rows,rows]; 
// int [,] array2 = new int[rows,rows]; 

// int[,]  GetArray (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,10);
//         }
//     }

//     return array;
// }

// void PrintArray(int[,] inputArray)    
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
//             Console.Write(inputArray[i,j]);
//         }
//         Console.WriteLine();
//     }
// }

// void ChangeArray(int[,] matrix,int[,] matrix2 )
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            matrix2[j,i]= matrix[i,j];
//         }
//     }
// }

// GetArray(array);
// PrintArray(array);
// ChangeArray(array,array2);
// System.Console.WriteLine();
// PrintArray(array2);

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет
//  строки на столбцы. В случае, если это невозможно, программа должна 
//  вывести сообщение для пользователя.

// Console.WriteLine("Введите размероность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размероность массива");
// int columns = Convert.ToInt32(Console.ReadLine());

// if(rows != columns)
// {
//     System.Console.WriteLine("Введите правильные числа");
//     return;
// }

// int [,] array = new int[rows,columns]; 
// int [,] array2 = new int[rows,columns]; 

// int[,]  GetArray (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,10);
//         }
//     }

//     return array;
// }

// void PrintArray(int[,] inputArray)    
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
//             Console.Write(inputArray[i,j]);
//         }
//         Console.WriteLine();
//     }
// }

// void ChangeArray(int[,] matrix,int[,] matrix2 )
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            matrix2[j,i]= matrix[i,j];
//         }
//     }
// }

// GetArray(array);
// PrintArray(array);
// ChangeArray(array,array2);
// System.Console.WriteLine();
// PrintArray(array2);
// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:


// Console.WriteLine("Введите размероность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размероность массива");
// int columns = Convert.ToInt32(Console.ReadLine());

// int minValue= int.MaxValue;
// int minRows=0;
// int minColumns= 0;

// int[,] GetArray (int m, int n)
// {
//     int [,] array = new int[m,n]; 

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,10);

//             if(array[i,j] <minValue)
//             {
//                 minValue = array[i,j];
//                 minRows= i;
//                 minColumns = j;
//             }
//         }
//     }

//     return array;
// }

// void PrintArray(int[,] inputArray)    
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
//             Console.Write(inputArray[i,j]);
//         }
//         Console.WriteLine();
//     }
// }

// void ChangeArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (minRows!= i && minColumns!=j)
//             {
//                 Console.Write(matrix[i,j]);
//             }
//         }
//         Console.WriteLine();
//     }
// }

// int[,] array2= GetArray(rows,columns);
// PrintArray(array2);
// System.Console.WriteLine();
// ChangeArray(array2);

// Задача 63: Задайте значение N. Напишите
//  программу, которая выведет все натуральные 
//  числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// string PrintNumbers(int start, int end)
// {
//     if(start == end)
//     {
//         return start.ToString();
//     }
//     return start+ " "+ PrintNumbers(start+1,end);
// }

// System.Console.WriteLine(PrintNumbers(1, num));