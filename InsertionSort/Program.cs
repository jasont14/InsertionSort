using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 2, 6, 5, 1, 9, 3 };

            Console.Write("Initial list: ");
            //Write inital list to console.
            foreach(int i in list)
            {
                Console.Write(i.ToString() + " ");                
            }

            InsertionSort(ref list);
                        
            Console.Write("\n\nSorted list: ");
            //Write sorted list to console.
            foreach (int i in list)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadLine();
        }

        public static void InsertionSort(ref int[] list)
        {
            //start at list[1] since list[0] is trivally sorted.

            for (int i = 1; i < list.Length; i++)
            {
                int intToEval = list[i]; //In the first round 6
                int j = i;

                while(j>0 && intToEval < list[j - 1])  //In the first round j = 1 but 6 is not less than 1.  will not swap.
                {
                    list[j] = list[j - 1];
                    list[j - 1] = intToEval;
                    j--;
                }
            }
        }
    }
}
