using System;


namespace HW10
{
    internal class Task1
    {
        interface ICalc
        {
            int Less(int valueToCompare);
            int Greater(int valueToCompare);
        }

        public class Array : ICalc
        {
            public int[] array;

            public Array(int[] array)
            {
                this.array = array;
            }

            public int Less(int valueToCompare)
            {
                int count = 0;
                foreach (var item in array)
                {
                    if (item < valueToCompare)
                        count++;
                }
                return count;
            }

            public int Greater(int valueToCompare)
            {
                int count = 0;
                foreach (var item in array)
                {
                    if (item > valueToCompare)
                        count++;
                }
                return count;
            }
        }
    }
}
