Console.Clear();
//чистим консоль

string[] arr = { "Hello", "2", "world", ":-)" };// тут можно задать значение вручную

//метод для ввода массива с клавиатуры
String[] inputArr(){
Console.WriteLine("Введите значения через запятую : ");
string input = Console.ReadLine();
if (!String.IsNullOrEmpty(input))
{
    Console.WriteLine("Вы ввели: " + input);
}
else
{
    Console.WriteLine("Вы ввели пустую строку");
}
string[] arr = input.Split(',');

    return arr;
}

// метод отбрасывает элементы больше трёх и создаёт из них новый массив, возвращая его. 
String[] arrayGenetrator(String[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }

    string[] result = new string[count];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            result[index] = arr[i];
            index++;
        }
    }

    return result;

}
//вывод результата в удобочитаемом виде разделяем через , ...
Console.WriteLine(string.Join(",", (arrayGenetrator(inputArr()))));