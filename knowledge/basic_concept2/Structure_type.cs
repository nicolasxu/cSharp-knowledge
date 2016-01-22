using System;

namespace CSharpKnowledge
{
	public class Structure_type
	{
		public Structure_type ()
		{
			// for for modeling mathematical, geometrical, and 
			// other “atomic” entities in your application.

		}
		public static void diff_from_class() {
			// 1. struct is value type, class is reference
			// 2. struct value is in stack, class value is in garbage collected heap
			// 3. struct cannot inheriteance, class can
			// 4. struct cannot be null(value type), class var can be null
			string source = "http://stackoverflow.com/questions/13049/whats-the-difference-between-struct-and-class-in-net";

		}
		public static void assign_struct() {
			// 1. it will result 2 copy of same data
			// 2. if struct contain a reference value, the reference is copied
		}

		public static void assign_class() {
			// 1. assigned by reference only, except
			// 2. reference reference
			//    static void SendAPersonByReference( ref Person p) {}
			//    SendAPersonByReference( ref mel);


		}
	}
}

