using System;

namespace CSharpKnowledge
{
	public class Virtual_override_sealed
	{
		public Virtual_override_sealed ()
		{
			// You can sealed override method to prevent further extending
		}
	}

	// example:
	class Employee {
		public virtual void GiveBonus(float amount) {
		}
	}
	class SalesPerson : Employee { 
		public override sealed void GiveBonus( float amount) { 
		/* ... */} 
	}

	sealed class PTSalesPerson : SalesPerson { 
		public PTSalesPerson( string fullName, int age, int empID, float currPay, string ssn, int
			numbOfSales) :base (fullName, age, empID, currPay, ssn, numbOfSales) { } 

		// Compiler error! Can’t override this method 
		// in the PTSalesPerson class, as it was sealed. 
		public override void GiveBonus( float amount) { 
			// error
		}
	}



}

