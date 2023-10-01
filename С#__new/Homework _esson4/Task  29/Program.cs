// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int arraySize = 8;

void PrintArray(int[] array){
    String result = String.Join(",",array);
    Console.WriteLine(result);
}

int[] getArray(int arraySize){
       int[] arr = new int[arraySize];
        for (int i = 0; i <arr.Length; i++)
        {
            arr[i] = new Random().Next(1,100);
        }
        return arr;
}

PrintArray(getArray(arraySize));


