/*
20 12 4 319 21 31234 2 41 23 4
Insert 50 2
Insert 50 5
Delete 4
end
.......
1 2 3 4 5 5 5 6
Delete 5
Insert 10 1
Delete 5
end
 */

namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program, that reads a list of integers
            //from the console and receives commands to manipulate the list
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            //You should exit the program when you receive the "end" command
            string command = "";
            while((command=Console.ReadLine()) != "end")
            {
                string[] argument = command.Split();

                switch (argument[0])
                {
                    case "Delete":
                        //Delete {element} – delete all elements in the array,
                        //which are equal to the given element.
                        int elementToDelete = int.Parse(argument[1]);
                        DeleteElements(list,elementToDelete);
                        break;
                    case "Insert":
                        //Insert {element} {position} – insert the element at the given position.
                        int elementToInsert = int.Parse(argument[1]);
                        int position = int.Parse(argument[2]);
                        InsertElement(list,elementToInsert, position);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }

        private static List<int> DeleteElements(List<int>list,int elementToDelete)
        {
            for(int i=0;i<list.Count;i++)
            {
                if (list[i] == elementToDelete)
                    list.Remove(elementToDelete);
            }
            return list;
        }

        private static List<int> InsertElement(List<int> list,int elementToInsert, int position)
        {
            list.Insert(position, elementToInsert);
            return list;
        }
    }
}