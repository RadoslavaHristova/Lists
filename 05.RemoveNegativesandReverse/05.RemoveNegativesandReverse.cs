namespace _05.RemoveNegativesandReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read a list of integers, remove all negative
            //numbers from it and print the remaining elements in reversed order.
            //If there are no elements left in the list, print "empty".

            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int>newList = new List<int>();

            for(int i=0; i<list.Count; i++)
            {
                if (list[i] >= 0) 
                {newList.Add(list[i]);} 
            }
            if (newList.Count<=0) 
            { Console.WriteLine("empty"); }

            else
            { newList.Reverse();
            Console.WriteLine(string.Join(" ",newList));}
        }
    }
}
//10 -5 7 9 -33 50
//-1 -2 -3