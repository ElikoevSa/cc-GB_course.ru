

int[] array = new int[102103];


void FillArray (int[] collection)
{
    int length = collection.Length;
    int i = 0 ; 
    while(i<length){
        collection[i] = new Random().Next(1,10200);
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

int IndexOff( int[] collection, int find){
    int posirion = 0;

    for (int i = 0; i < collection.Length; i++)
    {
         if (collection[i] == find)
         {
            posirion = i;
            Console.WriteLine(posirion);
            break;
         }       
    }
    return posirion;
}

FillArray(array);
PrintArray(array);

int pos = IndexOff(array , 1000);
Console.WriteLine(pos);