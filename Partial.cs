using System;

namespace CSharpKnowledge
{
	public class Partial
	{
		public Partial ()
		{
		}
	}
	// in file1.cs, file name doesn't matter
	partial class Employee { 
		// Field Data 
		// Constructors 
		// Methods 
		// Properties 
	}
	// in file2.cs
	partial class Employee {
		// other
	}
	// in file3.cs
	partial class Employee {
		// another
	}


}

