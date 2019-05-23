namespace ClassLibrary3
{
	public class Volfes : Predators
	{
		protected Volfes(string name)
			:base(name)
		{
			Name = name;
		}
		public override string Eat()
		{
			return "Я умею кусать";
		}
	}
}