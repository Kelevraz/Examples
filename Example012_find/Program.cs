int[] array = { 11, 32, 23, 44, 5, 643, 78, 81, 19 };

int n = array.Length;
int find = 4;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    index = index + 1;
    // index++;
}