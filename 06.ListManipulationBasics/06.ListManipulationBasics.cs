/*
4 19 2 53 6 43
Add 3
Remove 2
RemoveAt 1
Insert 8 3
end
.................
23 1 456 63 32 87 9 32
Remove 5 
Add 1 
Insert 14 2
RemoveAt 3
Add 34 
end
 */

namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a list of integers.
            List<int>list=Console.ReadLine().Split().Select(int.Parse).ToList();
            string commands = "";
            //Then until you receive "end", you will receive different commands:
            while((commands = Console.ReadLine()) != "end")
            {
                string[] arguments = commands.Split();
                switch (arguments[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(arguments[1]);
                        AddNumber(list,numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(arguments[1]);
                        RemoveNumber(list, numberToRemove);
                        break;
                    case "RemoveAt":
                        int index = int.Parse(arguments[1]);
                        RemoveNumberAtIndex(list, index);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(arguments[1]);
                        int indexToInsertNumber = int.Parse(arguments[2]);
                        InsertNumber(list, numberToInsert,indexToInsertNumber);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ",list));
        }

         static List<int> AddNumber(List<int>list,int numberToAdd)
        {
           list.Add(numberToAdd);
            return list;
        }

         static List<int> RemoveNumber(List<int> list, int numberToRemove)
        {
            list.Remove(numberToRemove);
            return list;
        }

         static List<int> RemoveNumberAtIndex(List<int> list, int index)
        { 
            list.RemoveAt(index);
            return list;
        }

         static List<int> InsertNumber(List<int> list, int numberToInsert, int indexToInsertNumber)
        {
            if (indexToInsertNumber < 0 || indexToInsertNumber > list.Count - 1)
            {
                return list;
            }
            else
            {
                list.Insert(indexToInsertNumber,numberToInsert);
                return list;
            }
        }
    }
}