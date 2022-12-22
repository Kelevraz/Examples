int[] array = { 11, 32, 23, 44, 5, 643, 78, 81, 19 };

int n = array.Length;
int find = 6;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index + 1;
    // index++;
}