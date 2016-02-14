using System;

namespace CSharpKnowledge
{
	public class interface_conflict
	{
		public interface_conflict ()
		{
		}
	}


	// example:
	// Draw image to a form. 
	public interface IDrawToForm { void Draw(); } 
	// Draw to buffer in memory. 
	public interface IDrawToMemory { void Draw(); } 
	// Render to the printer. 
	public interface IDrawToPrinter {
		void Draw();
	}

	class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter { 
		public void Draw() { 
			// Shared drawing logic. 
			Console.WriteLine(" Drawing the Octagon..."); 
			// all call will refer to the same draw method;
		} 
	}


	// solution:
	class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter { 
		// Explicitly bind Draw() implementations 
		// to a given interface. 
		void IDrawToForm.Draw() { Console.WriteLine(" Drawing to form..."); } 
		void IDrawToMemory.Draw() { Console.WriteLine(" Drawing to memory..."); } 
		void IDrawToPrinter.Draw() { Console.WriteLine(" Drawing to a printer..."); } 
	}

	// more generalized interface implementation:
	/*

		returnType InterfaceName.MethodName( params){}
	*/


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

