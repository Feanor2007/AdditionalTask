using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	class Chickens : Herbivores, IFlying
	{
		public Chickens(string _name)
			:base(_name)
		{
			Name = _name;
		}

		public void fly()
		{
			Console.WriteLine("Я умею летать");
		}
	}
}
