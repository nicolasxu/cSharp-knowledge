using System;

namespace CSharpKnowledge
{
	public class SystemDataType
	{
		public SystemDataType ()
		{
			/*
			bool
			sbyte
			byte
			short
			ushort
			int
			uint
			long
			ulong
			char
			float
			double
			decimal
			string
			Object

			*/
		}

		public void default_value() {
			/*
			bool => false
			NotFiniteNumberException => 0
			char => empty
			BigInteger => 0 
			DateTime => 1/1/0001 12:00:00 AM 
			Object => null 
			*/
			bool b = new bool();
			// b set false;
			int i = new int();
			// i set 0
		}

		public void Base_object_of_all_type() {
			// all data type derived from System.Object
			// so each type has:
			// ToString() 
			// Equals() 
			// GetHashCode() 

			// C# keyword (such as int) is simply shorthand 
			// notation for the corresponding system type (in this case, System.Int32),

		}
	}
}

