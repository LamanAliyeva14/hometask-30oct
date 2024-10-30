namespace Inheritance_DateTime_TimeSpan
{
	public class Book:Product
	{

		public string Genre;

		public Book(string name, int price, int count, string genre) : base(name, price, count)
		{
			Genre = genre;
		}
		
		public void Info()
		{
			if (string.IsNullOrWhiteSpace(Genre))
				Console.WriteLine("Add Genre");
			else
				Console.WriteLine("Name: " + Name + " Price:" + Price + " Count:"+Count + " Genre:" + Genre );

        }
	}
}

