using System;

namespace CSharpKnowledge
{
	public class base_keyword
	{
		public base_keyword ()
		{	
			// "this() is used to call constructor of this class, 
			// "base()" is used to call constructor of parent class"
			// - used to call base class constructor
			// - You may use the base keyword whenever a subclass wants to access a public 
			//   or protected member defined by a parent class.
			// - Not limited to constructor logic.

			// - Finally, recall that once you add a custom constructor to 
			//   a class definition, the default constructor is silently removed.


		}
	}

	// As a general rule, all subclasses should explicitly call an appropriate 
	// base class constructor. 
	class Employee {
		public Employee (string fullName,int age, string empID, string currPay, string ssn) {
		}
	}
	class SalesPerson: Employee {
		public SalesPerson( string fullName, int age, int empID, 
			float currPay, string ssn, int numbOfSales) : base( fullName, age, empID, currPay, ssn) {

		}
	}


}

