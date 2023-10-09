using System.Collections;
using System;

void EnteredNumber (){
        Console.Write("Введите числа через запятую: ");
        string inputNumber = Console.ReadLine();

        string[] numbers = inputNumber.Split(',');

        int count = 0;
        foreach (string number in numbers)
        {
            int num = Convert.ToInt32(number.Trim());
            if (num > 0)
            {
                count++;
            }
        }

        Console.WriteLine("Количество чисел больше 0: " + count);
}

//     System.Console.WriteLine("Введите значение от " + Int64.MinValue + " до " + Int64.MaxValue + ":");


//     ArrayList userNumbers = new ArrayList();
//     string userNumber = Console.ReadLine();

  


//     // try
//     // {
//     // long userNumber = Convert.ToInt64(Console.ReadLine());
        
//     // }
//     // catch (System.Exception)
//     // {
//     //     System.Console.WriteLine("Введён некорректный формат данных, " + 
//     //     "пожалуйста введите значение от " + Int64.MinValue + 
//     //     " до " + Int64.MaxValue + ":");

        
//     // }
//     // finally {
//     //     long userNumber = Convert.ToInt64(Console.ReadLine());
//     // }

        

//     return userNumbers;
// } 

EnteredNumber();