using System;

namespace CSharpKnowledge
{
	// example: 
	class Motorcycle { 
		public int driverIntensity; 
		public string driverName;
		// Constructor chaining. 
		public Motorcycle() {} 
		public Motorcycle(int intensity) : this( intensity, "") {
			// chained constructor executes first, then
			// execute code here
		} 
		public Motorcycle( string name) : this( 0, name) {} 
		// This is the ’master’ constructor that does all the real work.
		public Motorcycle( int intensity, string name) { 
			if (intensity > 10) { 
				intensity = 10; 
			} 
			driverIntensity = intensity; 
			driverName = name; 
		} /* ... */ 
	}


}

