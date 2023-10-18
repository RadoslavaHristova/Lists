namespace _01.SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().
                Split()
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < list.Count; i++) 
            {
                if (i + 1 > list.Count - 1)
                { break; }

                if (list[i] == list[i+1])
                {
                    list[i] += list[i+1];
                    list.RemoveAt(i+1);
                    i = -1;
                } 
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}