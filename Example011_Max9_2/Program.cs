﻿// массив:

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//               0   1   2   3  4   5   6   7   8 - индексы элементов массива
int[] array = { 11, 32, 23, 44, 5, 643, 78, 81, 19 };

// элементу массива с индексом 0 присваиваем значение 12:
// array[0] = 12;
// Console.WriteLine(array[0]);

int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);