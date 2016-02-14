using System;

namespace CSharpKnowledge
{
	public class interface_as_parameter
	{
		public interface_as_parameter ()
		{
		}

		// I’ll draw anyone supporting IDraw3D. 
		static void DrawIn3D(  IDraw3D itf3d) {
			if(itf3d is IDraw3d) {
				Console.WriteLine("-> Drawing IDraw3D compatible type"); 
				itf3d.Draw3D(); 
			}

		}


	}


}

