using System;

namespace CSharpKnowledge
{
	public class IEnumerator_interface
	{
		public IEnumerator_interface ()
		{
			// Iterator definition:
			// Simply put, an iterator is a member that specifies how a
			// container’s internal items should be returned when 
			// processed by foreach.



			// Iterate over an array of items.
			int[] myArrayOfInts = {10, 20, 30, 40};
			foreach( int i in myArrayOfInts) { 
				Console.WriteLine( i); 
			}
			// Any object that support IEnumerator.GetEnumerator()
			// can support foreach(... in...)

		}

		public void class_must_implement() {
			// class must implement this to support foreach

			// This interface informs the caller 
			// that the object’s items can be enumerated.
			public interface IEnumerable { IEnumerator GetEnumerator(); }

			// IEnumerator is like this:
			public interface IEnumerator { 
				bool MoveNext (); 
				// Advance the internal position of the cursor. 
				object Current { get;}
				// Get the current item (read-only property). 
				void Reset (); 
				// Reset the cursor before the first member. 
			}
		}
	}
	// example:

	using System.Collections; 
	public class Garage : IEnumerable { 
		// System.Array already implements IEnumerator! 
		private Car[] carArray = new Car[ 4]; public Garage()
		{ carArray[ 0] = new Car(" FeeFee", 200);
			carArray[ 1] = new Car(" Clunker", 90); 
			carArray[ 2] = new Car(" Zippy", 30); 
			carArray[ 3] = new Car(" Fred", 30); 
		} 

		// This allows the foreach
		public IEnumerator GetEnumerator() { 
			// Return the array object’s IEnumerator. 
			return carArray.GetEnumerator();
		} 
	}


	}


