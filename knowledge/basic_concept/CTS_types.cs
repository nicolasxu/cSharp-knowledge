using System;

namespace CSharpKnowledge
{
	class CTS_types {
		public CTS_types ()
		{
		}
		// 1. class type
		// example:
		class Calc {   
			public int Add(int x, int y)   {     return x + y;   } 
		}


		// 2. interface type
			// example:
			public interface IDraw {
				void Draw();
			}
		

		// 3. sruct type
		// example:
		struct Point {
			public int xPos, yPos;
			public Point(int x, int y) {
				xPos = x; yPos = y;
			}
			public void PrintPosition() {
				Console.WriteLine("({0}, {1})", xPos, yPos);
			}
		}


		// 4. enum type
		// example:
		enum CharacterType {
			Wizard  = 100,
			Fighter = 200,
			Thief   = 300
		}


		// 5. delegate type
		// delegate is type-safe function pointer
		delegate int BinaryOp(int x, int y);
		// can point to method that 
		//   1. returns int
		//   2. takes two ints as input


		// 6. intrisc_type
			// C# key words, byte, int, long, float, bool, string...
		
	}
}

