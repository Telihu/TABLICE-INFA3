﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = GenerateRandomArray(10); 

        Console.WriteLine("Tablica od tyłu:");
        PrintArrayReversed(array); 

        int minValue = FindMinValue(array); 
        Console.WriteLine("Najmniejsza wartość: " + minValue);

        int maxValue = FindMaxValue(array); 
        Console.WriteLine("Największa wartość: " + maxValue);

        InsertionSort(array); 
        Console.WriteLine("Posortowana tablica przez wstawianie:");
        PrintArray(array); 
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100); 
        }

        return array;
    }

    static void PrintArrayReversed(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(array[i]);
        }
    }

    static int FindMinValue(int[] array)
    {
        int minValue = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
            }
        }

        return minValue;
    }

    static int FindMaxValue(int[] array)
    {
        int maxValue = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
            }
        }

        return maxValue;
    }

    static void InsertionSort(int[] array)
    {
        int n = array.Length;

        for (int i = 1; i < n; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = key;
        }
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
