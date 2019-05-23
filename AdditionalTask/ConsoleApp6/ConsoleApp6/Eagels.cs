using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	public class Eagels : Predators, IFlying
	{
		public Eagels(string _name)
			: base(_name)
		{
			Name = _name;
		}
		public void fly()
		{
			Console.WriteLine("Я умею летать");
		}

	}
}
