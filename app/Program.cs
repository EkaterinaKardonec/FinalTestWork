using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = {
                "Hello", "2", "world", ":-)"
            };

            Print(Search(inputArray, 3));
        }

        public static string[] Search(string[] array, int maxLength)
        {
            string[] result = new string[calcCountElement(array, maxLength)];
            int j = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i].Length > maxLength)
                {
                    continue;
                }

                result[j] = array[i];
                j++;
            }

            return result;
        }

        public static void Print(string[] array)
        {
            int len = array.GetLength(0) - 1;

            Console.Write("[");
            
            for (int i = 0; i <= len; i++)
            {
                Console.Write(array[i]);

                if (i != len)
                {
                    Console.Write(", ");
                }
            }

            Console.Write("]");
        }

        public static int calcCountElement(string[] array, int maxLength)
        {
            int j = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i].Length > maxLength)
                {
                    continue;
                }

                j++;
            }

            return j;
        }
    }
}
