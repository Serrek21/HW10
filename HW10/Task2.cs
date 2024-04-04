using System;


namespace HW10
{
    internal class Task2
    {
        interface IOutput2
        {
            void ShowEven();
            void ShowOdd();
        }

        public class Array : IOutput2
        {
            public int[] array;

            public Array(int[] array)
            {
                this.array = array;
            }

            public void ShowEven()
            {
                Console.WriteLine("Even numbers:");
                foreach (var item in array)
                {
                    if (item % 2 == 0)
                        Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            public void ShowOdd()
            {
                Console.WriteLine("Odd numbers:");
                foreach (var item in array)
                {
                    if (item % 2 != 0)
                        Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
