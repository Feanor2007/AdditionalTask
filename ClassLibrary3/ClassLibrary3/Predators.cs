using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
	public class Predators : Animal, IFlying
	{

		public override string Eat()
		{
			return "Я умею кусать";
		}

		public Predators(string name)
		{
			Name = name;
		}

		public void fly()
		{
			Console.WriteLine("Я умею летать");
		}
	}
}
