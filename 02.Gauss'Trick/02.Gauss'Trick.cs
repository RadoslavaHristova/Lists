using System.Collections.Generic;

namespace _02.Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that sums all numbers
            //in a list in the following order:

            //first + last,
            //first + 1 + last - 1,
            //first + 2 + last - 2,
            //…
            //first + n, last - n

            List<int> list = Console.ReadLine().
                Split()
                .Select(int.Parse)
                .ToList();

             List<int> newList = new List<int>();
            
            //  1 2 3 4 5
            for (int i = 0; i < list.Count/2; i++)
            {
                
                newList.Add(list[i] + list[list.Count-i-1]);
            }
            
            if (list.Count % 2 == 1)
            { 
                newList.Add(list[list.Count / 2]);
            }
            
            
            Console.WriteLine(string.Join(" ", newList));
                
            
        }
    }
}