# Текстовое описание решения задачи
### 1. Задаём массив в ручную с помощью кода:
```csharp
string[] arr = { "Hello", "2", "world", ":-)" };
``` 
Через запятую в кавычках **" "** можно вводить любые параметры.

### 2. Создаём метод для ввода данных с клавиатуры.

```csharp

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
``` 


### 3. Создаём основной метод

Вся информаация в <span style="color:green"> комментах </span>
```csharp

// метод отбрасывает элементы больше трёх и создаёт из них новый массив, возвращая его. 
String[] arrayGenetrator(String[] arr)//здесь можно добавить переменную количество элементов
{
    int count = 0; //счётчик элементов будущего массива
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) //проходим по всему массиву, ищем есть ли в массиве элементы менее 3 символов если есть
        {
            count++;// то увеличиваем счётчик
        }
    }

    string[] result = new string[count]; //создаём новый массив на базе полученного счётчика
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) //проходим по массиву, запоминаем индексы и присваиваем из, если онеи есть 
        {
            result[index] = arr[i];
            index++;
        }
    }

    return result;

}

```

*Тут объяснять **нечего**!!!*

