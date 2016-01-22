using System;

namespace CSharpKnowledge
{
	public class Nullable_type
	{
		public Nullable_type ()
		{
			// Nullable is useful in data base, so bool can have true, false and null value. 
		}
		public void nullable_value_type() {
		
			int? nullableInt = 10; 
			double? nullableDouble = 3.14; 
			bool? nullableBool = null; 
			char? nullableChar = 'a'; 
			int?[] arrayOfNullableInts = new int?[ 10];

			// Error! Strings are reference types! 
			// string? s = "oops";

		}
		public void nullable_T() {
		
			// Define some local nullable types using Nullable < T >. 
			Nullable < int > nullableInt = 10; 
			Nullable < double > nullableDouble = 3.14; 
			Nullable < bool > nullableBool = null; 
			Nullable <char> nullableChar = 'a';
			Nullable < int >[] arrayOfNullableInts = new Nullable < int >[10];

		
		}

		public void null_related_operator() {
			
			// 1. ?? -> isNull()
			// Null Coalescing Operator
			//   If the value from GetIntFromDatabase() is null, 
			//   assign local variable to 100.
			int myData = dr.GetIntFromDatabase() ?? 100;

			// 2. ?  -> only access Length if not null
			// Null conditional operator
			Console.WriteLine( $" You sent me {args?.Length} arguments.");

		}

	}
}

