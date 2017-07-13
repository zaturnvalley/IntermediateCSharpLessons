using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersTwo
{
	public class Customer
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public void Promote()
		{

		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			var customer = new Customer();
		}
	}
}
