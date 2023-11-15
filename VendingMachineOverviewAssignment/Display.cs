using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineOverviewAssignment
{
	public class Display
	{
		public void VendingMachineMenu()
		{
			int choice;
			do
			{
				Console.WriteLine(
				"\t\t\nWelcome to the Vending Machine\n" +
				"\t\t1.\tInsert Money" +
				"\t\t2.\tChoose a Product" +
				"\t\t3.\tChange Calculate" +
				"\t\t4.\tChange Return" +
				"\t\t\nPlease make your choice: ");
				choice = int.Parse(Console.ReadLine());

				switch(choice)
				{
					case 1: Cash.MoneyInput(); break;
					case 2: Cash.CostOfProducts(); break;
					case 3: Cash.AmountOfChange(); break;
					case 4: Cash.MoneyOutput(); break;
					case 5: Cash.MoneyInput(); break;
					case 6: Cash.MoneyInput(); break;
					case 7: Cash.MoneyInput(); break;
					case 8: Cash.MoneyInput(); break;
					case 9: Environment.Exit(0); break;
				}

			} while (choice!=9);
		}
	}
}
