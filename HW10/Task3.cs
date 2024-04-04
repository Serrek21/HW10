using System;

namespace HW10
{
    internal class Task3
    {
        interface ICalc2
        {
            int CountDistinct();
            int EqualToValue(int valueToCompare);
        }

        public class Array : ICalc2
        {
            public int[] array;

            public Array(int[] array)
            {
                this.array = array;
            }

            public int CountDistinct()
            {
                int distinctCount = 0;
                bool[] visited = new bool[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    if (!visited[i])
                    {
                        distinctCount++;
                        for (int j = i + 1; j < array.Length; j++)
                        {
                            if (array[i] == array[j])
                                visited[j] = true;
                        }
                    }
                }

                return distinctCount;
            }

            public int EqualToValue(int valueToCompare)
            {
                int count = 0;
                foreach (int value in array)
                {
                    if (value == valueToCompare)
                        count++;
                }
                return count;
            }
        }
    }
}
