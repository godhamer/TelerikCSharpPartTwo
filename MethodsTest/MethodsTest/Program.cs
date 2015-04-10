﻿using System;

class Sort
{
    static void Sorting(int[] array)
    {
        int temp, element;

        for (int j = 0; j < array.Length - 1; j++)
        {
            element = j;

            for (int k = j + 1; k < array.Length; k++)
            {
                if (array[k] < array[element])
                {
                    element = k;
                }
            }
            temp = Swap(array, element, j);
        }
    }
    static int Swap(int[] array, int element, int j)
    {
        int temp = array[element];
        array[element] = array[j];
        array[j] = temp;
        return temp;
    }    
    static void Output(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] array = { 7, 2, 1, 4, 5, 8, 11, 10, 9, 3 };
        Sorting(array);
        Output(array);
    }

    
}