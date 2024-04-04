using HW10;
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Task 1
        Console.WriteLine("Task 1:");
        int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Task1.Array arr1 = new Task1.Array(array1);
        Console.WriteLine("Number of elements less than 5: " + arr1.Less(5));
        Console.WriteLine("Number of elements greater than 5: " + arr1.Greater(5));
        Console.WriteLine();

        // Task 2
        Console.WriteLine("Task 2:");
        int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Task2.Array arr2 = new Task2.Array(array2);
        arr2.ShowEven();
        arr2.ShowOdd();
        Console.WriteLine();

        // Task 3
        Console.WriteLine("Task 3:");
        int[] array3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3 };
        Task3.Array arr3 = new Task3.Array(array3);
        Console.WriteLine("Count of distinct values: " + arr3.CountDistinct());
        Console.WriteLine("Count of values equal to 3: " + arr3.EqualToValue(3));
        Console.WriteLine();

        // Write results to file
        using (StreamWriter writer = new StreamWriter("output.txt"))
        {
            writer.WriteLine("Task 1:");
            writer.WriteLine("Number of elements less than 5: " + arr1.Less(5));
            writer.WriteLine("Number of elements greater than 5: " + arr1.Greater(5));
            writer.WriteLine();

            writer.WriteLine("Task 2:");
            arr2.ShowEven();
            arr2.ShowOdd();
            writer.WriteLine();

            writer.WriteLine("Task 3:");
            writer.WriteLine("Count of distinct values: " + arr3.CountDistinct());
            writer.WriteLine("Count of values equal to 3: " + arr3.EqualToValue(3));
            writer.WriteLine();
        }

        Console.WriteLine("Results written to output.txt");
    }
}