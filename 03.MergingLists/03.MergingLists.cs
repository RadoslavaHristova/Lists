namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>listOne=Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int>listTwo=Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int>newList=new List<int>();

           for (int i = 0; i < listOne.Count; i++) 
            {
                newList.Add(listOne[i]);
                if (listTwo.Count >i)
                { newList.Add(listTwo[i]);}
            }
           if(listTwo.Count>listOne.Count)
            {
                listTwo.RemoveRange(0,listOne.Count);
                newList.AddRange(listTwo);
            }
            
            Console.WriteLine(string.Join(" ",newList));
        }
    }
}
/*
76 5 34 2 4 12
3 5 2 43 12 3 54 10 23
 */