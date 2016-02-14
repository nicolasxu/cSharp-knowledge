using System;

namespace CSharpKnowledge
{
	public class interface_as_return_value
	{
		public interface_as_return_value ()
		{
		}
	}
	public interface IPointy {
	}
	// This method returns the first object in the 
	// array that implements IPointy. 
	public static IPointy FindFirstPointyShape( Shape[] shapes) { 
		foreach (Shape s in shapes) { 
			if (s is IPointy) {
				return s as IPointy;
			}
		} 
		return null; }

}

