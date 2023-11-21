namespace VendingMachineOverviewAssignment
{
	public class Inventory
	{
		public static List<Product>? listOfProducts;		
		public Inventory()
		{
			listOfProducts = new List<Product>
			{
				new Toys
				( "The LOL:er", "Fun, if you´re young enough", 1, 1, 250, 10, "0-99" ),
				new Snacks
				( "Santa Belly", "Soft Chewing Candy", 2, 2, 20, 10, "Raspberry" ),
				new Fruit
				( "Scary Banana", "A way too green or brown banana", 3, 3, 15, 10, "Asparagus Banana", "Banana" ),
				new Drinks
				( "Liquid Dream", "Fizzy Drink without Taste", 4, 4, 15, 10, "Colafudge", "Soda" ),
				new OtherNonConsumables
				( "Airpimper", "For refill needs", 5, 5, 125, 10, "Pump Stuff" ),				
			};			
		}
		public static void DisplayShowAll()
		{
			foreach (var item in listOfProducts)
			{
				Console.WriteLine(
				$"ID #: {item.ProductId} \t" +
				$"{item.ProductName} \t" +
				$"{item.ProductPrice:C}");
			}
            Console.WriteLine("\n");
        }
		public static void DisplayExamine()
		{
			foreach (var item in listOfProducts)
			{
				Console.WriteLine(
				$"Product # {item.ProductId} \n" +
				$"{item.ProductName} \n" +
				$"{item.ProductDescription}"); 
			}
		}
	}
}