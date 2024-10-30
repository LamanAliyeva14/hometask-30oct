using System.Diagnostics;
using System.Xml.Linq;

namespace Inheritance_DateTime_TimeSpan;
internal class Program
{
    static void Main(string[] args)
    {
        

        Product pr1 = new Product("Book", 25, 1200);
        pr1.Detail();


        int percent = 50;
        int discountedprice = pr1.DiscountPrice(percent);
        Console.WriteLine($"Discount price: { discountedprice}");

        Book b1 = new Book("Book1", 30, 900, "Detective");
        b1.Info();

        Console.WriteLine("Enter the number: ");
        int length = int.Parse(Console.ReadLine());
        Book[] arr = new Book[length];

        for (int i=0; i<length; i++)
        {
            Console.WriteLine($"Enter the name of book {i+1}:");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter the price of book {i + 1}: ");
            int price= int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the count of book {i + 1}: ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the genre of book {i + 1}: ");
            string genre = Console.ReadLine();

            arr[i] = new Book(name, price, count, genre);

        }
        Console.WriteLine("Choose option:1 2 0");
        int choose = int.Parse(Console.ReadLine());
        switch (choose)
        {
            case 1:
            case 0:
                Console.WriteLine("Bye");
                break;

            case 2:
                foreach(Book book in arr)
                {
                    Console.WriteLine("Name: " + book.Name + " Price:" + book.Price + " Count:" + book.Count + " Genre:" + book.Genre);
                }
                break;
                

        }
        
        
      


            
    }
}


