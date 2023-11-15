
using VendingMachineOverviewAssignment;

List<IVending> vendingMachine = new List<IVending>();
VendingMachineService service = new VendingMachineService();
Inventory inventory = new Inventory();

vendingMachine.Add(service);

foreach(IVending vending in vendingMachine)
{
	vending.InsertMoney();
	//vending.ShowAll();
	vending.Purchase();	
	//vending.Details();	
	vending.EndTransaction();
}

Console.ReadKey();
public interface IVending
{
	void InsertMoney();
	void ShowAll();
	void Purchase();
	void Details();
	void EndTransaction();
}

public class VendingMachineService : IVending
{
	public void InsertMoney()
	{
		Console.WriteLine(
		"\t\tWELCOME TO THE VENDINGMACHINE !\n\n" +
		"Denominations is entered in the following order:\n" +
		"1000, 500, 200, 100, 50, 20, 10, 5, 2, 1\n");
		Cash.MoneyInput();
	}
	public void ShowAll()
	{		
        Inventory.DisplayShowAll();		
	}
	public void Purchase()
	{
		Console.Clear();
		Cash.UserChoice();
		Cash.CostOfProducts();		
	}
	public void Details()
	{
		Inventory.DisplayExamine();		
	}
	public void EndTransaction()
	{		
		Cash.AmountOfChange();
		Cash.MoneyOutput();
        Console.WriteLine("Thank you for using the Vending Machine !");
    }		
}