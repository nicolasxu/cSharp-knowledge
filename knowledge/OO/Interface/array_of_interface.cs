using System;

namespace CSharpKnowledge
{
	public class array_of_interface
	{
		public array_of_interface ()
		{
		}
	}

	static void Main( string[] args) { 
		//... 
		// This array can only contain types that 
		// implement the IPointy interface. 
		IPointy[] myPointyObjects = {new Hexagon(), 
			new Knife(), 
			new Triangle(), 
			new Fork(), 
			new PitchFork()
		}; 
		foreach( IPointy i in myPointyObjects) {
			Console.WriteLine(" Object has {0} points.", i.Points); 
		}
		Console.ReadLine(); 
	}

}

