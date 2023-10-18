/*
5 34 678 67 5 563 98
Contains 23
PrintOdd
GetSum
Filter >= 21
end
--------------
2 13 43 876 342 23 543
Contains 100
Contains 543
PrintEven
PrintOdd
GetSum
Filter >= 43
Filter < 100
end
 */
namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a list of integers.
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string commands = "";
            int counterOfPreviosTask=0;
            //Then until you receive "end", you will receive different commands:
            while ((commands = Console.ReadLine()) != "end")
            {
                string[] arguments = commands.Split();
                switch (arguments[0])
                {
                    case "Contains":
                        int number = int.Parse(arguments[1]);
                        ContainsNumber(list, number);
                        
                        break;

                    case "PrintEven":
                        PrintEven(list);
                        break;

                    case "PrintOdd":
                        PrintOdd(list); 
                        break;

                    case "GetSum":
                        GetSum(list); 
                        break;

                    case "Filter":
                        string condition = arguments[1];
                        int numberChecker = int.Parse(arguments[2]);
                        Filter(list,condition,numberChecker); 
                        break;

                    case "Add":
                        int numberToAdd = int.Parse(arguments[1]);
                        AddNumber(list, numberToAdd);
                        counterOfPreviosTask++;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(arguments[1]);
                        RemoveNumber(list, numberToRemove);
                        counterOfPreviosTask++;
                        break;
                    case "RemoveAt":
                        int index = int.Parse(arguments[1]);
                        RemoveNumberAtIndex(list, index);
                        counterOfPreviosTask++;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(arguments[1]);
                        int indexToInsertNumber = int.Parse(arguments[2]);
                        InsertNumber(list, numberToInsert, indexToInsertNumber);
                        counterOfPreviosTask++;
                        break;
                }
            }
            if (counterOfPreviosTask>0)
            { Console.WriteLine(string.Join(" ", list)); }


        }

        

        private static void ContainsNumber(List<int> list, int number)
        {
            //Contains {number} – check if the list contains the number and
            //if so - print "Yes", otherwise print "No such number".
            if (list.Contains(number))
            { Console.WriteLine("Yes");}
            else 
            { Console.WriteLine("No such number");}
             
        }
        
        private static void PrintEven(List<int> list)
        {
            //PrintEven – print all the even numbers, separated by a space.
            List<int> result = new List<int>();
            for (int i = 0; i < list.Count; i++)
            { 
                if (list[i]%2==0)
                { result.Add( list[i]); }
            }
            Console.WriteLine(string.Join(" ",result));
        }
        
        private static void PrintOdd(List<int> list)
        {
            //PrintOdd – print all the odd numbers, separated by a space.
            List<int> result = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                { result.Add( list[i]); }
            }
            Console.WriteLine(string.Join(" ", result));
        }
        
        private static void GetSum(List<int> list)
        {
            //GetSum – print the sum of all the numbers
            int sum = 0;
            for(int i=0; i<list.Count; i++) 
            { sum += list[i]; }
            Console.WriteLine(sum);
        }

        private static void Filter(List<int> list, string condition, int numberChecker)
        {
            //Filter {condition} {number} –
            //print all the numbers that fulfill the given condition.
            //The condition will be either '<', '>', ">=", "<=".
            List<int>result= new List<int>();
            switch (condition) 
            {
                case "<":
                    for(int i=0;i<list.Count;i++)
                    {
                        if (numberChecker > list[i])
                        { result.Add(list[i]); } 
                    }
                    break;
                case ">":
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (numberChecker < list[i])
                        { result.Add(list[i]); }
                    }
                    break;
                case ">=":
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (numberChecker <= list[i])
                        { result.Add(list[i]); }
                    }
                    break;
                case "<=":
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (numberChecker >= list[i])
                        { result.Add(list[i]); }
                    }
                    break;

            }
            Console.WriteLine(string.Join(" ", result));
        }
        static List<int> AddNumber(List<int> list, int numberToAdd)
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
                list.Insert(indexToInsertNumber, numberToInsert);
                
                return list;
            }
        }
    }
}