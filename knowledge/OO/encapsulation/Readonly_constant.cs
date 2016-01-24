using System;

namespace CSharpKnowledge
{
	public class Readonly_constant
	{
		public Readonly_constant ()
		{
			// - constant member can only be assigned at declaration, then no change allowed. 
			// - constant is determined at compile time only
			// - readonly member can only be assigned at class constructor, then no change allowed
			// - readonly can be determined at runtime.
		}

	}
	// example:
	class MyMathClass { 
		// Read-only fields can be assigned in ctors, 
		// but nowhere else. 
		public readonly double PI;
		public MyMathClass () { 
			PI = 3.14; 
		} 
	}

	}

