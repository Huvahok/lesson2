﻿int n = 10;
int[] array = { 2, 5, 7, 8, 35, 1, 3, 8, 5, 4};
int i = 0;

while (i < array.Length)
{
    if(array[i] % 2 == 0)
    {
        System.Console.WriteLine($"{array[i]} ");
    }
    i += 1;
}