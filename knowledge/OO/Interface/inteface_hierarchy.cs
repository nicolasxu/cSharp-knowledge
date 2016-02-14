using System;

namespace CSharpKnowledge
{
	public class inteface_hierarchy
	{
		public inteface_hierarchy ()
		{
			// 1. Unlike class, mutiple interface inherentence is allowed. 
			// 2. Implementing child interface will require you to implement
			//    all ancestor interface. 
		}
	}



	// 1. Single inheritance example:
	public interface IDrawable { void Draw(); }
	public interface IAdvancedDraw : IDrawable {
		// so if you implement IAdvancedDraw, you have to implement Draw();
		void DrawInBoundingBox( int top, int left, int bottom, int right); 
		void DrawUpsideDown(); 
	}

	// 2. Multiple inheritance example: 
	// Multiple inheritance for interface types is a-okay.
	interface IDrawable { void Draw(); } 
	interface IPrintable {
		void Print(); 
		void Draw(); // <-- Note possible name clash here!
	} // Multiple interface inheritance. OK!
	interface IShape : IDrawable, IPrintable { 
		int GetNumberOfSides(); 
	}

	// In implementing IShape, you can implement 3 methods
	// - Draw()
	// - Print()
	// - GetNumberOfSides()
	// or you can implement 4 methods, since there is a name clash
	// - IDrawable.Draw()
	// - IPrintable.Draw()
	// - Print()
	// - GetNumberOfSides();
}

