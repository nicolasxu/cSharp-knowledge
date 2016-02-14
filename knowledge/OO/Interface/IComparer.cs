using System;

namespace CSharpKnowledge
{
	public class IComparer
	{
		public IComparer ()
		{
		}
	}

	// A general way to compare two objects. 
	interface IComparer { 
		int Compare( object o1, object o2); 
	}

	// example: 
	// This helper class is used to sort an array of Cars by pet name. 
	public class PetNameComparer : IComparer {
		// Test the pet name of each object. 
		int IComparer.Compare( object o1, object o2) { 
			Car t1 = o1 as Car;
			Car t2 = o2 as Car;
			if (t1 != null && t2 != null) {
				return String.Compare (t1.PetName, t2.PetName);
			} else {
				throw new ArgumentException (" Parameter is not a Car!");
			}
		} 
	}

	// using the comparer
	static void Main( string[] args) { 
		// Now sort by pet name.
		Array.Sort( myAutos, new PetNameComparer());
		// Dump sorted array. 
		Console.WriteLine(" Ordering by pet name:"); 
		foreach( Car c in myAutos) {
			Console.WriteLine("{ 0} {1}", c.CarID, c.PetName);
		}
	}

	// Example: put comparer in class as static
	public class Car : IComparable { 
		// Property to return the PetNameComparer. 
		public static IComparer SortByPetName {
			get { return (IComparer) new PetNameComparer(); } 
		}
	}

	// Sorting by pet name made a bit cleaner. 
	Array.Sort( myAutos, Car.SortByPetName);






}

