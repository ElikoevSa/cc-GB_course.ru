int[] array = new int[103];


void FillArray (int[] collection)
{
    int length = collection.Length;
    int i = 0 ; 
    while(i>length){
        collection[i] = new Random().Next(0,10000);
        i++;
    }
}

void PrintArray (int[] col){
    int position = 0;
    int count = col.Length;

    while(position<count){
        Console.WriteLine(col[position]);
        position++;
    }
}

FillArray(array);
PrintArray(array);