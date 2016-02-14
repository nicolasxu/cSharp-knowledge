using System;

namespace CSharpKnowledge
{
	public class invoking_mixed_array_of_instance
	{
		public invoking_mixed_array_of_instance ()
		{
			// an array of class instance, some of them implement IPointy, 
			// some of them don't. 
			// If you invoke interface method on object that doesn't implement
			// interface, you will get method. 


			// Method 1: try .. catch
			// Method 2: as keyword
			// Method 3: is keyword

		}



	}

	static void Main( string[] args) {
		//... 
		// Catch a possible InvalidCastException. 
		Circle c = new Circle(" Lisa"); 
		IPointy itfPt = null; 
		try { itfPt = (IPointy) c; 
			Console.WriteLine( itfPt.Points); 
		} catch (InvalidCastException e) { 
			Console.WriteLine( e.Message);
		} Console.ReadLine(); 
	}

	// Method 2: as keyword
	static void Main( string[] args) { 
			//... // Can we treat hex2 as IPointy? 
		Hexagon hex2 = new Hexagon(" Peter");
		IPointy itfPt2 = hex2 as IPointy; 
		if( itfPt2 != null) {
			Console.WriteLine(" Points: {0}", itfPt2. Points);
		} else {
			Console.WriteLine(" OOPS! Not pointy...");
		} 
		Console.ReadLine(); 
	}

	// Method 3: is keyword
	static void Main( string[] args) { 
		Console.WriteLine("***** Fun with Interfaces *****\ n"); 
		// Make an array of Shapes. 
		Shape[] myShapes = { new Hexagon(), 
			new Circle(), 
			new Triangle(" Joe"), 
			new Circle(" JoJo")
		}; 
		for( int i = 0; i < myShapes.Length; i + +) {
			// Recall the Shape base class defines an abstract Draw() 
			// member, so all shapes know how to draw themselves. 
			myShapes[ i]. Draw();
			// Who’s pointy? 
			if( myShapes[ i] is IPointy) { 
			Console.WriteLine("-> Points: {0}", (( IPointy) myShapes[ i]). Points);
			} else {
				Console.WriteLine("-> {0}\’ s not pointy!", myShapes[ i]. PetName); 
			}
			Console.WriteLine(); 
		} 
		Console.ReadLine(); 
	}




}

