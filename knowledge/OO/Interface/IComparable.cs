using System;

namespace CSharpKnowledge
{
	public class IComparable
	{
		public IComparable ()
		{
		}
	}


	// This interface allows an object to specify its 
	// relationship between other like objects.
	public interface IComparable { int CompareTo( object o); }

	// example:

	public class Car : IComparable { 
		// IComparable implementation. 
		int IComparable.CompareTo( object obj) { 
			Car temp = obj as Car; 
			if (temp != null) { 
				if (this.CarID > temp.CarID) {
					return 1;
					// this instance comes after object
				}
			 
				if (this.CarID < temp.CarID) {
					return -1;
					// this instance comes before the object
				} else {
					return 0;
				} 
			} else {
				throw new ArgumentException(" Parameter is not a Car!");
			}
		} 
	}
}

