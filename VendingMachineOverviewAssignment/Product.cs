using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineOverviewAssignment
{
	public abstract class Product : VendingMachineService
	{
		public string? ProductName { get; set; }
		public string? ProductDescription { get; set; }
		public int ProductId { get; set; }
		public int ProductCategoryId { get; set; }
		public int ProductPrice { get; set; }
		public int Quantity { get; set; }

		public abstract void Examine();
		public abstract void Use();

		public Product(
		string productName, 
		string productDescription, 
		int productId, 
		int productCategoryId, 
		int productPrice, 
		int quantity)
		{
			ProductName = productName;
			ProductDescription = productDescription;
			ProductId = productId;
			ProductCategoryId = productCategoryId;			
			ProductPrice = productPrice;
			Quantity = quantity;			
		}		

	}

	#region Product Types Classes

	public class Snacks : Product
	{
		public string? Taste { get; set; }

		public Snacks(
		string productName, 
		string productDescription, 
		int productId, 
		int productCategoryId, 
		int productPrice, 
		int quantity, 
		string taste)
			: base(
			productName, 
			productDescription, 
			productId, 
			productCategoryId, 
			productPrice, 
			quantity)
		{
			Taste = taste;
		}

		public override void Examine()
		{
			Console.WriteLine(
			$"Product Info:\n" +
			$"ID: {ProductId}\n" +
			$"Name: {ProductName}\n" +
			$"Description: {ProductDescription} \n" +
			$"Category ID: {ProductCategoryId} \n" +
			$"Product Price: {ProductPrice} \n" +
			$"Available Quantity: {Quantity}  \n" +
			$"Unique Feature: {Taste}  \n"
			);
		}
		public override void Use()
		{
			Console.WriteLine("Crunch, Crunch...*GULP* *SIGH* AHHH SUGAR !!!!");
		}
	}
	public class Drinks : Product
	{
		public string? TypeOfDrink { get; set; }
		public string? Taste { get; set; }

		public Drinks(
		string productName, 
		string productDescription, 
		int productId, 
		int productCategoryId, 
		int productPrice, 
		int quantity, 
		string taste, 
		string type)
			: base(
			productName, 
			productDescription, 
			productId, 
			productCategoryId, 
			productPrice, 
			quantity)
		{
			TypeOfDrink = type;
			Taste = taste;
		}

		public override void Examine()
		{
			Console.WriteLine(
			$"Product Info:\n" +
			$"ID: {ProductId}\n" +
			$"Name: {ProductName}\n" +
			$"Description: {ProductDescription} \n" +
			$"Category ID: {ProductCategoryId} \n" +
			$"Product Price: {ProductPrice} \n" +
			$"Available Quantity: {Quantity}  \n" +
			$"Drink Type: {TypeOfDrink}  \n" +
			$"Unique Feature: {Taste}  \n"
			);
		}
		public override void Use()
		{
			Console.WriteLine("Slurp, Slurp...*UGH* *SADFACE* That was disappointing!!!!");
		}
	}
	public class Fruit : Product
	{
		public string? TypeOfFruit { get; set; }
		public string? Taste { get; set; }

		public Fruit(
		string productName, 
		string productDescription, 
		int productId, 
		int productCategoryId, 
		int productPrice, 
		int quantity, 
		string taste, 
		string type)
			: base(
			productName, 
			productDescription, 
			productId, 
			productCategoryId, 
			productPrice, 
			quantity)
		{
			Taste = taste;
			TypeOfFruit = type;
		}

		public override void Examine()
		{
			Console.WriteLine(
			$"Product Info:\n" +
			$"ID: {ProductId}\n" +
			$"Name: {ProductName}\n" +
			$"Description: {ProductDescription} \n" +
			$"Category ID: {ProductCategoryId} \n" +
			$"Product Price: {ProductPrice} \n" +
			$"Available Quantity: {Quantity}  \n" +
			$"Fruit Type: {TypeOfFruit}  \n" +
			$"Unique Feature: {Taste}  \n"
			);
		}

		public override void Use()
		{
			Console.WriteLine("Chew, *SWALLOW*...*HMMM* *INDIFFERENT FACE* Okay I guess");
		}
	}
	
	public class OtherNonConsumables : Product
	{
		public string? AreaOfUse { get; set; }

		public OtherNonConsumables(
		string productName, 
		string productDescription, 
		int productId, 
		int productCategoryId, 
		int productPrice, 
		int quantity, 
		string usage)
			: base(
			productName, 
			productDescription, 
			productId, 
			productCategoryId, 
			productPrice, 
			quantity)
		{
			AreaOfUse = usage;
		}

		public override void Examine()
		{
			Console.WriteLine(
			$"Product Info:\n" +
			$"ID: {ProductId}\n" +
			$"Name: {ProductName}\n" +
			$"Description: {ProductDescription} \n" +
			$"Category ID: {ProductCategoryId} \n" +
			$"Product Price: {ProductPrice} \n" +
			$"Available Quantity: {Quantity}  \n" +
			$"Unique Feature: {AreaOfUse}  \n"
			);
		}

		public override void Use()
		{
			Console.WriteLine("Oh man,how does this work ?? *POKES*...*HMMM* *CONFUSED FACE* Maybe like this");
		}
	}
	public class Toys : Product
	{
		public string? AgeGroup { get; set; }

		public Toys(
		string productName, 
		string productDescription, 
		int productId, 
		int productCategoryId, 
		int productPrice, 
		int quantity, 
		string agegroup)
			: base(
			productName, 
			productDescription, 
			productId, 
			productCategoryId, 
			productPrice, 
			quantity)
		{
			AgeGroup = agegroup;
		}

		public override void Examine()
		{			
			Console.WriteLine(
			$"Product Info:\n" +
			$"ID: {ProductId}\n"+
			$"Name: {ProductName}\n" +
			$"Description: {ProductDescription} \n" +
			$"Category ID: {ProductCategoryId} \n" +
			$"Product Price: {ProductPrice} \n" +
			$"Available Quantity: {Quantity}  \n" +
			$"Unique Feature: {AgeGroup}  \n"
			);			
		}

		public override void Use()
		{
			Console.WriteLine("Something to play with *HAPPY FACE* YAY");
		}
	}

	#endregion

}