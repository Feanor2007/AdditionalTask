using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	public class Mooses:Herbivores
	{
		private int Horns;
		private int _hornsChanched;
		public Mooses(string _name, int horns )
			:base(_name)
		{
			Horns = horns;
			Name = _name;

		}

		public int ChangeNumberOfHorns(int horns)
		{
			_hornsChanched = horns * 2;
			return _hornsChanched;
		}
	}
}
