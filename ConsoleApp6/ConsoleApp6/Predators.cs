using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	public class Predators : Animal
	{

		public override string Eat()
		{
			base.Eat();
			return "Я умею кусать";
		}

		public Predators(string name)
		{
			Name = name;
		}

	}
}
