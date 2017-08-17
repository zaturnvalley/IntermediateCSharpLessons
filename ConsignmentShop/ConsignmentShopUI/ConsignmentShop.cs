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
		private List<Item> shoppingCartData = new List<Item>();
		BindingSource itemsBinding = new BindingSource();
		BindingSource cartBinding = new BindingSource();
		BindingSource vendorsBinding = new BindingSource();
		private decimal storeProfit = 0;

		public ConsignmentShop()
		{
			InitializeComponent();
			SetupData();

			itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
			itemsListBox.DataSource = itemsBinding;

			itemsListBox.DisplayMember = "Display";
			itemsListBox.ValueMember = "Display";

			cartBinding.DataSource = shoppingCartData;
			shoppingCartListBox.DataSource = cartBinding;

			shoppingCartListBox.DisplayMember = "Display";
			shoppingCartListBox.ValueMember = "Display";

			vendorsBinding.DataSource = store.Vendors;
			vendorListBox.DataSource = vendorsBinding;

			vendorListBox.DisplayMember = "Display";
			vendorListBox.ValueMember = "Display";
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

			store.Items.Add(new Item
			{
				Title = "1Q84",
				Description = @"A love story, a mystery, a fantasy, a novel of self-discovery, 
					a dystopia to rival George Orwell’s—1Q84 is Haruki Murakami’s most ambitious 
					undertaking yet: an instant best seller in his native Japan, and a tremendous 
					feat of imagination from one of our most revered contemporary writers.",
				Price = 5.50M,
				Owner = store.Vendors[1]
			});

			store.Items.Add(new Item
			{
				Title = "Kafka on the Shore",
				Description = @"Kafka on the Shore is powered by two remarkable characters: a teenage boy, 
					Kafka Tamura, who runs away from home either to escape a gruesome oedipal prophecy or 
					to search for his long-missing mother and sister; and an aging simpleton called Nakata, 
					who never recovered from a wartime affliction and now is drawn toward Kafka for reasons 
					that, like the most basic activities of daily life, he cannot fathom.",
				Price = 4.10M,
				Owner = store.Vendors[0]
			});

			store.Name = "Half Price Books";
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

		private void addToCart_Click(object sender, EventArgs e)
		{
			// Figure out what is selected from the items list

			Item selectedItem = (Item)itemsListBox.SelectedItem;

			// Copy that item to the shopping cart

			shoppingCartData.Add(selectedItem);
			cartBinding.ResetBindings(false);

			// Do we remove the item from the items list? - no

		}

		private void makePurchase_Click(object sender, EventArgs e)
		{
			// Mark each item in the cart as sold

			foreach (Item item in shoppingCartData)
			{
				item.Sold = true;
				item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
				storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;
			}

			// Clear the cart
			shoppingCartData.Clear();

			itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

			cartBinding.ResetBindings(false);
			itemsBinding.ResetBindings(false);
			vendorsBinding.ResetBindings(false);
		}

	}
}
