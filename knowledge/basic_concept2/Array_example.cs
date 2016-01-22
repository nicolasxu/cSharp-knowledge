using System;

namespace CSharpKnowledge
{
	public class Array_example
	{
		public Array_example ()
		{
			string[] booksOnDotNet = new string[ 100];
			int[] myInts = new int[ 3];
			// if you declare an array but do not explicitly fill 
			// each index, each item will be set to the default 
			// value of the data type


			// Compile time error: 
			int[] intArray = new int[ 2] { 20, 22, 23, 0 };

			// Error! Mixed types! 
			var d = new[] { 1, "one", 2, "two", false };


			// implicitly typed array
			var a = new[] { 1, 10, 100, 1000 };


		}

		public void array_init () {
			// method 1:
			string[] stringArray = new string[] { "one", "two", "three" };
			int[] intArray = new int[ 4] { 20, 22, 23, 0 };


			// method 2:
			bool[] boolArray = { false, false, true };
			// when you make use of this “curly-bracket” syntax, 
			// you do not need to specify the size of the array



		
		}

		static void ArrayOfObjects() { 

			// Normaly one array for one data type, except object

			Console.WriteLine(" = > Array of Objects."); 
			// An array of objects can be anything at all.
			object[] myObjects = new object[ 4]; 
			myObjects[ 0] = 10;
			myObjects[ 1] = false;
			myObjects[ 2] = new DateTime( 1969, 3, 24); 
			myObjects[ 3] = "Form & Void"; 
			foreach (object obj in myObjects) { 
				// Print the type and value for each item in array. 
				Console.WriteLine(" Type: {0}, Value: {1}", obj.GetType(), obj); 
			} 
			Console.WriteLine(); 
		}

		static void multi_dimension_array() {
			// 1. declare
			int[,] myMatrix; 
			myMatrix = new int[ 3,4];

			// 2. populate
			for( int i = 0; i < 3; i ++) 
				for( int j = 0; j < 4; j ++) 
					myMatrix[ i, j] = i * j;


		}

		static void jagged_multi_dimention_array() {
			// jagged arrays contain some number of inner arrays, 
			// each of which may have a different upper limit.
			// Here we have an array of 5 different arrays. 
			int[][] myJagArray = new int[5][];

			for (int i = 0; i < myJagArray.Length; i ++) 
				myJagArray[ i] = new int[ i + 7];
			// Print each row (remember, each element is defaulted to zero!). 
			for( int i = 0; i < 5; i ++) { 
				for( int j = 0; j < myJagArray[ i]. Length; j ++) 
					Console.Write( myJagArray[ i][ j] + " "); 
				Console.WriteLine(); 
			}



		}

		static void array_method() {
			
			string[] gothicBands = {"band 1", "band 2", "band 3" };

			Array.Reverse( gothicBands);

			Array.Clear( gothicBands, 1, 2); // clear the index 1 and index 2


		}

	}
}

