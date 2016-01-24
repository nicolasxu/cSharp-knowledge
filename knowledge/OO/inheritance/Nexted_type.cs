using System;

namespace CSharpKnowledge
{
	public class Nexted_type
	{
		public Nexted_type ()
		{
			// key points:

			// 1. Non-nested classes cannot be private. 
			// 2. Because a nested type is a member of the containing class, 
			//    it can access private members of the containing class. 
			// 3. Often, a nested type  is not intended for use by the outside world.

		}
	}

	// example 1: 
	public class OuterClass { 
		// A public nested type can be used by anybody. 
		public class PublicInnerClass {} 
		// A private nested type can only be used by members 
		// of the containing class. 
		private class PrivateInnerClass {} 
	}

	// example 2: use of nested type outside containing class

	// OuterClass.PublicInnerClass inner1; 
	// OuterClass.PrivateInnerClass inner2; /* Compiler error */


}

