using System;

namespace CSharpKnowledge
{
	public class Catch_chain_exception
	{
		public Catch_chain_exception ()
		{
			// 1. catch the most specific Exception first
			// 2. catch the most general Exception last, 
			//  or other exception can not be reached.




		}

		public static void Example () {
		

			Console.WriteLine("***** Handling Multiple Exceptions *****\ n"); 
			Car myCar = new Car(" Rusty", 90); 
			try { 
				// Trigger an argument out of range exception. 
				myCar.Accelerate(-10); 
			}
			catch (CarIsDeadException e) { 
				Console.WriteLine( e.Message); 
			} 
			catch (ArgumentOutOfRangeException e) {
				Console.WriteLine( e.Message); 
			} 
			// This will catch any other exception 
			// beyond CarIsDeadException or 
			// ArgumentOutOfRangeException.
			catch (Exception e) { 
				Console.WriteLine( e.Message); 
			} Console.ReadLine(); 
			


		
		}
	}
}

