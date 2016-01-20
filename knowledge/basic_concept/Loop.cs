using System;

namespace CSharpKnowledge
{
	public class Loop
	{
		public Loop ()
		{
		}

		public void for_loop() {
			for (int i = 0; i < 4; i++) {
				System.Console.WriteLine ("Number is: {0} ", i);
			}
		}
		public void foreach_loop() {
			// example 1
			string[] carTypes = {"Ford", "BMW", "Yugo", "Honda"};

			foreach (string carType in carTypes) {
				Console.WriteLine (carType);
			}

			// example 2
			int[] myInts = { 10, 20, 30, 40 }; 
			foreach (int i in myInts) 
				Console.WriteLine( i);

			// example 3
			int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
			var subset = from i in numbers where i < 10 select i; 
			Console.Write(" Values in subset: "); 
			foreach (var i in subset) { 
				Console.Write("{ 0} ", i); 
			}


		}

		public void while_loop() {
			string userIsDone = ""; // Test on a lower-class copy of the string. 
			while( userIsDone.ToLower() != "yes") { 
				Console.WriteLine(" In while loop"); 
				Console.Write(" Are you done? [yes] [no]: "); 
				userIsDone = Console.ReadLine(); 
			}

		}
	}
}

