/*
32 54 21 12 4 0 23
75
Add 10
Add 0
30
10
75
end
...........
0 0 0 10 2 4
10
Add 10
10
10
10
8
6
end
 */

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //On the first line, we will receive a list of wagons (integers).
            //Each integer represents the number of passengers that are currently
            //in each wagon of the passenger train.--> 32 54 21 12 4 0 23
            List<int>list =Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            //On the next line, you will receive the max capacity of a wagon,
            //represented as a single integer-->75
            int wagonCapacity=int.Parse(Console.ReadLine());

            //Until you receive the "end" command, you will be receiving
            //two types of input:
            string command = "";
            while ((command = Console.ReadLine())!="end")
            {
                string[]arguments= command.Split();
                if (arguments[0]=="Add")
                { list.Add(int.Parse(arguments[1])); }
                else
                {
                    for(int i=0;i<list.Count;i++)
                    { if (list[i] + int.Parse(arguments[0])<=wagonCapacity)
                        { list[i]=list[i]+int.Parse(arguments[0]);
                            break; }
                    }
                }
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}