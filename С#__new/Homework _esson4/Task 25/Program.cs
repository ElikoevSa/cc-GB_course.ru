// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void powNumbers(int A, int B)
{
    int result = A;
    for (int i = 1; i < B; i++)
    {
         result = result*A;
    }
Console.WriteLine(result);
}

double powNumbersMath(double A, double B){
    return Math.Pow(A,B);
}

powNumbers(2,4);
System.Console.WriteLine(powNumbersMath(2.2,2));