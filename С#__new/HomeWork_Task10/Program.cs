//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


// static bool IsPalindrome(int number){
//       // Введите свое решение ниже
//         if (number < 10000 || number > 99999){
//           Console.WriteLine("Число не пятизначное");
//           return false;
//         }
//         string number_srt = number.ToString();
//       char[] strch = number_srt.ToCharArray();
//       Array.Reverse(strch);     
//       string temp = new string(strch);

//       if(number_srt == temp)
//       {
//         return true;
//         }
//       else return false;
//     }

//     Console.WriteLine(IsPalindrome(64541));

using System;

static double Length(int[] pointA, int[] pointB)
    {
      // Введите свое решение ниже
     double firstCordonate = Math.Pow((pointA[1] - pointA[0]),2);
     double secondCordinate = Math.Pow((pointB[1] - pointB[0]),2);
     double result = Math.Sqrt(firstCordonate + secondCordinate);
     return result;
    }
