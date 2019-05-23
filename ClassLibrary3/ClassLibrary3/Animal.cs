using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public abstract class Animal
    {
	    public string Name { get; set; }

	    public virtual string Eat()
	    {
		    return "eating";
	    }
    }
	
}
