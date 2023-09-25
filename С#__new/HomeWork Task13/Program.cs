//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6





int num = new Random().Next(1,2100000000);
Console.WriteLine("Num = " + num);
if(num >99){
    while(num>999){
        num/=10;
    }
Console.WriteLine(num% 10);
}
else{
    Console.WriteLine("третьей цифры нет");
}
