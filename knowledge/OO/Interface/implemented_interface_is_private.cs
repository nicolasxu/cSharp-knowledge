using System;

namespace CSharpKnowledge
{
	public class implemented_interface_is_private
	{
		public implemented_interface_is_private ()
		{
			// 1. Because explicitly implemented members are always 
			//    implicitly private, these members are no longer 
			//    available from the object level.

			// 2. you must use explicit casting to access the
			//    required functionality.

			// 3. or you can explicitly declare the implemented interface public
		
		}
	}

	static void Main( string[] args) { 
		Console.WriteLine("***** Fun with InterfaceName Clashes *****\ n"); 
		Octagon oct = new Octagon();
		// We now must use casting to access the Draw()  // members. 
		IDrawToForm itfForm = (IDrawToForm) oct; 
		itfForm.Draw(); 
		// Shorthand notation if you don’t need 
		// the interface variable for later use. 
		(( IDrawToPrinter) oct).Draw(); 
		// Could also use the "is" keyword. 
		if( oct is IDrawToMemory) {

			(( IDrawToMemory)oct).Draw(); 

		}
		Console.ReadLine(); 
	}


}

