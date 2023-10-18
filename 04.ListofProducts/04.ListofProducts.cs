namespace _04.ListofProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read a number n and n lines of products.
            int productsQty=int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            while (productsQty > 0)
            {
                string product = Console.ReadLine();
                products.Add(product);
                productsQty--;
            }
            products.Sort();
            //Print a numbered list of all the products ordered by name
            for(int i = 0; i < products.Count; i++) 
            {
                Console.WriteLine($"{i+1}.{products[i]}");
            }
        }
    }
}
/*
4
Potatoes
Tomatoes
Onions
Apples
 */