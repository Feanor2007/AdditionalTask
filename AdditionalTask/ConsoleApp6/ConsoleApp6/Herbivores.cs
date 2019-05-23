using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	public class Herbivores : Animal
	{
		private string _nameOfHerbivores;
		protected Herbivores(string _nameOfHerbivores)
		{
			Name = _nameOfHerbivores;
		}

		public void Crunch()
		{
			Console.WriteLine("Я умею кусать");
		}

		Herbivores herb = new Herbivores("Herb");
	}

}
