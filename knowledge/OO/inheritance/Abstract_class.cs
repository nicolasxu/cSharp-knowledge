using System;

namespace CSharpKnowledge
{
	public class Abstract_class
	{
		public Abstract_class ()
		{	
			// Key points:
			// 1. For extending only, can not be newed
			// 2. sub class of abstract class doesn't have to override virtual method.
			//    You can, but not have to. 
			// 3. abstract method can only be in abstract class
			// 4. abstract method force child class to override this method

		}
	}

	// example: 
	abstract partial class Employee { 
		public abstract void Pay() {
			// child must override abstract method, 
			// child does not have to override virtual method
			// abstract method must be in abstract class, or compiling error

			//“I have a method named Pay() that takes no arguments and returns nothing. 
			// If you derive from me, you figure out the details.”

		}
	}
	// Error! Cannot create an instance of an abstract class! 
	Employee X = new Employee();

}

