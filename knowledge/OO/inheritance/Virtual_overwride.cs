using System;

namespace CSharpKnowledge
{
	public class Virtual_overwride
	{
		public Virtual_overwride ()
		{
			// Overriding virtual method is Polymorphism
		}
	}

	// example:
	partial class Employee { 
		// This method can now be "overridden" by a derived class. 
		public virtual void GiveBonus( float amount) { 
			Pay + = amount; 
		} 
		/* ... */
	}

	class Manager : Employee {  
		
		public override void GiveBonus( float amount) { 
			base.GiveBonus( amount); // reuse base method
			Random r = new Random(); 
			StockOptions += r.Next( 500); 
		} 
	}




}

