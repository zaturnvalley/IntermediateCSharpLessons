﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
	public class Circle : Shape
	{
		public override void Draw()
		{
			// Any code specifi to the circle itself
			Console.WriteLine("Draw a circle");
		}
	}
	public class Rectangle : Shape
	{
		public override void Draw()
		{
			Console.WriteLine("Draw a rectangle");
		}
	}
	public class Shape
	{
		public int Width { get; set; }
		public int Height { get; set; }
		public Position Position { get; set; }

		public virtual void Draw()
		{

		}
	}
}
