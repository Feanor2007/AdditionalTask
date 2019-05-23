using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
	class Program
	{
		static void Main(string[] args)
		{
			Predators Volf1 = new Predators("Volf1");
			Predators Eagel1 = new Predators("Eagel1");
			Herbivores Chicken1 = new Herbivores("Chicken1");
			Herbivores Moose1 = new Herbivores("Moose1");

			PredatorsOfZoo.Add(Volf1);
			PredatorsOfZoo.Add(Eagel1);

			HerbivoresOfZoo.Add(Chicken1);
			HerbivoresOfZoo.Add(Moose1);

			AnimalOfZoo.Add(Volf1);
			AnimalOfZoo.Add(Eagel1);
			AnimalOfZoo.Add(Chicken1);
			AnimalOfZoo.Add(Moose1);

			Chicken1.Eat();
			Chicken1.Crunch();
			Chicken1.fly();

			Moose1.Crunch();
			Moose1.Eat();

			Eagel1.Eat();
			Eagel1.fly();

			Volf1.Eat();
		}
	}
}
