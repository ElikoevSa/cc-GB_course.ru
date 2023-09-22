int [] array = {1,4,23,34,5,6,34,3,2,1,76,84,44553,32,3};
int n = array.Length;
int find = 4;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;

    }
    index++;
}



