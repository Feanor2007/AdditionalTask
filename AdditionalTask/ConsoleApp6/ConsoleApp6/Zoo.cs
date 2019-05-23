using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	public class Zoo
	{
		private string Name1 = "Herbivores";
		private string Name2 = "Predators";

		public void SpeciesOfZoo()
		{
			Console.WriteLine("Zoo has {0} and {1}", Name1, Name2);
		}

	}	
}
