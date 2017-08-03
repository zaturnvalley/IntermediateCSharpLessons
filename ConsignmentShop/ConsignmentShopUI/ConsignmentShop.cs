using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsignmentShopLibrary;

namespace ConsignmentShopUI
{
	public partial class ConsignmentShop : Form
	{
		private Store store = new Store();

		public ConsignmentShop()
		{
			InitializeComponent();
		}

		private void SetupData()
		{
			//Dummy data
			store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Johnson"});
			store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Smith"});

			//Populating Items
			store.Items.Add(new Item {
				Title ="War & Peace",
				Description = @"Following the fortunes and the rise and 
					fall of five aristocratic families in the waning days of imperial Russia.",
				Price = 4.50M,
				Owner = store.Vendors[0] });

			store.Items.Add(new Item
			{
				Title = "East of Eden",
				Description = @"Set in the rich farmland of California's Salinas Valley, 
					this sprawling and often brutal novel follows the intertwined destinies 
					of two families—the Trasks and the Hamiltons—whose generations helplessly 
					reenact the fall of Adam and Eve and the poisonous rivalry of Cain and Abel.",
				Price = 3.50M,
				Owner = store.Vendors[1]
			});
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void ConsignmentShop_Load(object sender, EventArgs e)
		{

		}

		private void removeFromCart_Click(object sender, EventArgs e)
		{

		}
	}
}
