using System;

namespace CSharpKnowledge
{
	public class Method_overload
	{
		public Method_overload ()
		{
			// C# allows a method to be overloaded. 
			// Simply put, when you define a set of identically named methods
			// that differ by the number (or type) of parameters, the method 
			// in question is said to be overloaded.
		}

		// examples: 
		static int Add( int x, int y) { return x + y; } 
		static double Add( double x, double y) { return x + y; } 
		static long Add( long x, long y) { return x + y; }

	}
}

