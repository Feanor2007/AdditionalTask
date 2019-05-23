using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
	public class Herbivores : Animal, IFlying
	{
		public string Name { get; set; }

		public Herbivores(string Name)
		{
			this.Name = Name;
		}

		public void Crunch()
		{
			Console.WriteLine("Я умею кусать");
		}
		public void fly()
		{
			Console.WriteLine("Я умею летать");
		}

		Herbivores Chicken = new Herbivores("Chicken");
		Herbivores Moose = new Herbivores("Moose");

	}
}
