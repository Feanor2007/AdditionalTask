using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	class Program
	{
		static void Main(string[] args)
		{
			Volfes Volf1 = new Volfes("Volf1");
			Eagels Eagel1 = new Eagels("Eagel1");
			Chickens Chicken1 = new Chickens("Chicken1");
			Mooses Moose1 = new Mooses("Moose1", 2);;

			List<Animal> AnimalOfZoo = new List<Animal>();
			List<Predators> PredatorsOfZoo = new List<Predators>();
			List<Herbivores> HerbivoresOfZoo = new List<Herbivores>();

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

			int numberOfAnimal = AnimalOfZoo.Count();
			Console.WriteLine(numberOfAnimal);

			int numberOfPredatorsOfZoo = PredatorsOfZoo.Count();
			Console.WriteLine(numberOfPredatorsOfZoo);

			int numberOfHerbivoresOfZoo = HerbivoresOfZoo.Count();
			Console.WriteLine(numberOfHerbivoresOfZoo);
		}
	}
}
