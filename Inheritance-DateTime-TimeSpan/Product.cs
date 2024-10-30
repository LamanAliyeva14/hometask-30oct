using System;
namespace Inheritance_DateTime_TimeSpan
{

    public class Product
    {
        public string Name;
        public int Price;
        public int Count;


        public Product()
        {

        }

        public Product(string name, int price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
        public void Detail()
        {
            
            if (string.IsNullOrWhiteSpace(Name) || Price<=0)
                Console.WriteLine("Add name and/or price");
            else
            {
                Console.WriteLine("Name:" + Name + " Price:" + Price + " Count:" + Count);
            }

        }

        public int DiscountPrice(int percent)
        {
            int discountprice = Price - (Price * percent / 100);
            return discountprice;
        }

       

        
    }
}

