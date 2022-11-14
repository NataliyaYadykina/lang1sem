// 

int[] array = new int[10] {1,2,3,4,5,6,7,8,9,10};

for(int i = 0; i < array.Length / 2; i++)
{
    int temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
}

for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
