using System;

namespace CSharpKnowledge
{
	public class Type_narow_widen
	{
		public Type_narow_widen ()
		{
			// 1. compailer will always detect type narrow error
			// 2. to void error, use explicit type cast ()
			//    This may cause data loss. 
		}

		public void check_overflow() {
			byte b1 = 100;
			byte b2 = 250;
			byte b3 = b1 + b2; // overflow!!!
			// since max value for byte is 256


			// solution
			try {
				checked(b3 = b1 + b2);

				// or
				checked {
					b3 = b1 + b2;
				}

			} catch(OverflowException ex) {
				Console.WriteLine (ex.Message);
			}

		}

		public void project_wide_overflow_check() {
		
			// the C# compiler supports the /checked flag. 
			// When enabled, all your arithmetic will be evaluated for 
			// overflow without the need to make use of the C# checked keyword.

		
		}
		public void uncheck_keyword() {
			// for a block where data overflow loss is acceptable 
			unchecked {
				byte sum = (byte)(50 + 50);
				Console.WriteLine (sum);
			}
		}

		public void var_key_word() {
			// 1. var can only be used in a local variable in a function
			//    it cannot be a field data. (class property)
			// 2. Can not be used for return data in function definition.
			// 3. Must assign a value when declared. 
			// 4. Cannot assign with null when declared
			// 5. Cannot change type for var during its life span. 

			var myInt = 0;
			var myBool = true; 
			var myString = "Hello, world!";
			Console.WriteLine(" myInt is a: {0}", myInt.GetType(). Name); 
			Console.WriteLine(" myBool is a: {0}", myBool.GetType(). Name); 
			Console.WriteLine(" myString is a: {0}", myString.GetType(). Name);

		}
		public void useful_situation_for_var() {
			int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 }; 
			// LINQ query! 
			var subset = from i in numbers where i < 10 select i;

		}


	}
}

