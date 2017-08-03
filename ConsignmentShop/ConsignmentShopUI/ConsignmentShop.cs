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
			//Vendor demoVendor = new Vendor();

			//demoVendor.FirstName = "Bill";
			//demoVendor.LastName = "Smith";
			//demoVendor.Commission = .5;

			//store.Vendors.Add(demoVendor);

			//demoVendor = new Vendor();

			//demoVendor.FirstName = "Sue";
			//demoVendor.LastName = "Jones";
			//demoVendor.Commission = .5;

			//store.Vendors.Add(demoVendor);

			//store.Vendors = new List<Vendor>();

			store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Johnson"});
			store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Smith"});

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
