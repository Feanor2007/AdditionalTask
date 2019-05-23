using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	public class Volfes : Predators
	{
		public Volfes(string name)
			: base(name)
		{
			Name = name;
		}
		public override string Eat()
		{
			return "Я умею кусать";
		}
	}

}
