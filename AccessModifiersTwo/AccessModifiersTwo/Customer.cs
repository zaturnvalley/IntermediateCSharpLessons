﻿using System;

namespace AccessModifiersTwo
{
	public class Customer
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public void Promote()
		{
			Console.WriteLine("Promote logic changed.");
		}

	}
}
