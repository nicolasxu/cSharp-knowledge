using System;

namespace CSharpKnowledge
{
	public class interface_syntac
	{
		public interface_syntac ()
		{
		}
	}


	public interface IPointy { 
		// Implicitly 
		// public and abstract. 
		byte GetNumberOfPoints(); // no implementation
		byte Points { get; }

		// no fields
		// no property
		// no implementation

	}

	// IPointy p = new IPointy(); // Compiler error!

	public class Pencil: IPointy {
	
	}
	public class SwitchBlade : object, IPointy {
		//	...
	}
	// This class derives from a custom base class 
	// and implements a single interface. 
	public class Fork : Utensil, IPointy {
			//...
	} 
	// This struct implicitly derives from System.ValueType and 
	// implements two interfaces. 
	public struct PitchFork : ICloneable, IPointy {
	//		...
	}

	class Triangle: Shape, IPointy {

		// implement property method Points get
		public byte Points {
			get { return 3; }
		}
	}



}

