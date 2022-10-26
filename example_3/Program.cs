// 
void FillArray(int[] collection)
{
    for(int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(1, 10);
    }
}
void PrintArray(int[] collection)
{
    for(int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
    Console.WriteLine();
}
void arraySort(int[] collection)
{
    for(int i = 0; i < collection.Length - 1; i++)
    {
        int minpos = i;
        for(int y = i + 1; y < collection.Length; y++)
        {
            if(collection[y] < collection[minpos]) minpos = y;
        }


        int temp = collection[i];
        collection[i] = collection[minpos];
        collection[minpos] = temp;
    }
}
int[] array = new int[10];
FillArray(array);
PrintArray(array);
arraySort(array);
PrintArray(array);


