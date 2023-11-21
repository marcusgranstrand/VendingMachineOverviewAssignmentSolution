namespace VendingMachineOverviewAssignment
{
	public class Cash
	{
		static readonly Product productOne = new Toys("The LOL:er", "Fun if you´re young enough", 1, 1, 250, 10, "0-99");
		static readonly Product productTwo = new Snacks("Santa Belly", "Soft Chewing Candy", 2, 2, 20, 10, "Raspberry");
		static readonly Product productThree = new Fruit("Scary Banana", "A way too green or brown banana", 3, 3, 15, 10, "Asparagus Banana", "Banana");
		static readonly Product productFour = new Drinks("Liquid Dream", "Fizzy Drink without taste", 4, 4, 15, 10, "Colafudge", "Soda");
		static readonly Product productFive = new OtherNonConsumables("Airpimper", "For refill needs", 5, 5, 125, 10, "Pump Stuff");
		
		static readonly int[] denominations = { 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
		static readonly int[] numDenominations = new int[10];

		public static int BuyingCost { get; set; }
		public static int TotalAmount { get; set;}
		public static int Change { get; set; }
		public static int Price { get; set; }
		public static int AvailableMoney { get; set; }

		public static int MoneyInput()
		{			
			int amountDenominations;
			
			for (int i = 0; i < denominations.Length; i++)
			{
                Console.WriteLine($"Enter amount of {denominations[i]}: ");
				amountDenominations = int.Parse(Console.ReadLine()); 
				TotalAmount += amountDenominations * denominations[i];
				AvailableMoney = TotalAmount;
				Console.WriteLine($"Total amount is: {TotalAmount:C}");
            }
			
			return TotalAmount;
        }

		public static int UserChoice()
		{
			int choice;
			do
			{
				Inventory.DisplayShowAll();
				Console.WriteLine($"You got: {AvailableMoney:C} to buy for.");
				Console.WriteLine($"Please enter Id of product you wish to buy: (9 to Exit)");
				choice = int.Parse(Console.ReadLine());
				
				switch (choice)
				{
					case 1:
						productOne.Examine();
						Price = productOne.ProductPrice;
						BuyingCost += Price;
						if(AvailableMoney >= Price)
						{
							productOne.Use();
							AvailableMoney = TotalAmount - BuyingCost;
							Thread.Sleep(3000);
							Console.Clear();
						}
						else
						{
							throw new Exception("There is not enough money!");
						}                        
						break;
					case 2:
						productTwo.Examine();
						Price = productTwo.ProductPrice;
						BuyingCost += Price;
						if (AvailableMoney >= Price)
						{
							productTwo.Use();
							AvailableMoney = TotalAmount - BuyingCost;
							Thread.Sleep(3000);
							Console.Clear();
						}
						else
						{
							throw new Exception("There is not enough money!");
						}
						break;
					case 3:
						productThree.Examine();
						Price = productThree.ProductPrice;
						BuyingCost += Price;
						if (AvailableMoney >= Price)
						{
							productThree.Use();
							AvailableMoney = TotalAmount - BuyingCost;
							Thread.Sleep(3000);
							Console.Clear();
						}
						else
						{
							throw new Exception("There is not enough money!");
						}
						break;
					case 4:
						productFour.Examine();
						Price = productFour.ProductPrice;
						BuyingCost += Price;
						if (AvailableMoney >= Price)
						{
							productFour.Use();
							AvailableMoney = TotalAmount - BuyingCost;
							Thread.Sleep(3000);
							Console.Clear();
						}
						else
						{
							throw new Exception("There is not enough money!");
						}
						break;
					case 5:
						productFive.Examine();
						Price = productFive.ProductPrice;
						BuyingCost += Price;
						if (AvailableMoney >= Price)
						{
							productFive.Use();
							AvailableMoney = TotalAmount - BuyingCost;
							Thread.Sleep(3000);
							Console.Clear();
						}
						else
						{
							throw new Exception("There is not enough money!");
						}
						break;

					default: Console.WriteLine(); break;
				} 			
				
			}while (AvailableMoney > 0 && choice != 9) ;

			return Price;
		}
		public static int CostOfProducts()
		{
			Console.WriteLine($"The total cost for the products is: {BuyingCost:C}\n");
            return BuyingCost;
		}

		public static int AmountOfChange()
		{
			Change = TotalAmount-BuyingCost;
            Console.WriteLine($"The change is: {Change}\n");
            return Change;
		}
		
		public static Dictionary<int,int> MoneyOutput()
		{
			Dictionary<int, int> change = new Dictionary<int, int>();
			for (int i = 0; i < denominations.Length; i++)
			{
				while (Change >= denominations[i])
				{
					Change -= denominations[i];
					numDenominations[i]++;
				}
				change.Add(denominations[i], numDenominations[i]);
			}
			foreach (var(key,value) in change)
			{
				Console.WriteLine($"Denomination: {key} Amount: {value}");
			}

            return change;
		}		
	}
}