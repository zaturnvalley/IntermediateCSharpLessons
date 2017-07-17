using Amazon;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersTwo
{
	class Program
	{
		static void Main(string[] args)
		{
			var customer = new Customer();
			Amazon.RateCalculator calculator = new RateCalculator();
		}
	}
}
