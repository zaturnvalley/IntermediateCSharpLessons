using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
	public class Rectangle : Shape
	{
		public override void Draw()
		{
			Console.WriteLine("Draw a rectangle.");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			var circle = new Circle();
			circle.Draw();

			var rectangle = new Rectangle();
			rectangle.Draw();
			Console.ReadLine();
		}
	}
}
