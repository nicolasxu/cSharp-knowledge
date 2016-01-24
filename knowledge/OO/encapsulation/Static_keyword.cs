using System;

namespace CSharpKnowledge
{
	public class Static_keyword
	{
		public Static_keyword ()
		{
			/* where static can be used:
			 
			- Data of a class 
			- Methods of a class 
			- Properties of a class 
			- A constructor 
			- The entire class definition 
			- In conjunction with the C# using keyword
			*/
		}

		public void common_error() {

			// 1. static method cannot access non static member
			// 2. static method cannot use this.xxx. It is an error. 
		
		}
		public void member_init_syntax_for_static_member() {
			// below code in a class will only execute once, no matter how many object you newed. 
			// public static double currInterestRate = 0.04;

		}
		public void static_constructor() {
			// - only run one time for your class, no matter how many object you newed. 
			// - Is the place to init static member
			// - Each class only have one static constructor, no overload.
			// - The static constructor executes before any instance-level constructors.

		}
		public void static_class() {
			// - can not use new operator
			// - can only contain static fields
			// - just use the method and constant in the class
			//   e.g.: Math.rand();

		}
		public void static_import() {
			// example:
			// if a class only contains static members, 
			// you can:
			// using static System.Console;
			// using static System.DateTime;

			// then you can 
			// WriteLine( Now.ToShortTimeString());
			// instead of
			Console.WriteLine("fdafdsa");

			// save some typing, but over use can lead to confusion.


		}
	}
}

