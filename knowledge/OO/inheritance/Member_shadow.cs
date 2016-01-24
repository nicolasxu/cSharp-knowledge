using System;

namespace CSharpKnowledge
{
	public class Member_shadow
	{
		public Member_shadow ()
		{
			// sub class has the exact same method or field, no virtual or abstract
			// in parents method or fields.
			// So things in child class will shadow the parent class and 
			// trigger a compiler warning. 

			// use new keyword to explicitly mark the override. 
		}
	}
	// example:
	class Circle {
		private string name;
		public void Draw() {
		}
	}
	class ThreeDCircle : Circle { 
		private new string name; // shadowing name in parent
		public new void Draw() { // shadow Draw() in parent
			Console.WriteLine(" Drawing a 3D Circle"); 
		} 
	}

	class Main {
		static void main() {
			
			ThreeDCircle o = new ThreeDCircle(); 
			// This calls the Draw() method of the ThreeDCircle. 
			o.Draw(); 
			// This calls the Draw() method of the parent! 
			(( Circle) o). Draw(); 
			Console.ReadLine();
		}

	}



}

