using System;

namespace CSharpKnowledge
{

	// example:
	class Rectangle { 
		private Point topLeft = new Point(); 
		private Point bottomRight = new Point(); 
		public Point TopLeft { 
			get { return topLeft; } 
			set { topLeft = value; } 
		} 
		public Point BottomRight {
			get { return bottomRight; } 
			set { bottomRight = value; } 
		}
		public void DisplayStats() { 
			Console.WriteLine("[ TopLeft: {0}, {1}, {2} BottomRight: {3}, {4}, {5}]", 
				topLeft.X, topLeft.Y, topLeft.Color, bottomRight.X, bottomRight.Y, bottomRight.Color); 
		} 
	}

	class Main {

		public void method1() {
			Rectangle myRect = new Rectangle { TopLeft = new Point { X = 10, Y = 10 }, 
				BottomRight = new Point { X = 200, Y = 200} 
			};
		}
	}




}

