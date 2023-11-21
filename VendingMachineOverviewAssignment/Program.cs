
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

