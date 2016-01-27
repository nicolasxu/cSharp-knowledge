using System;

namespace CSharpKnowledge
{
	public class Final
	{
		public Final ()
		{
			// To make sure some code are always executed
		}
		public void example() {
		
			Car myCar = new Car(" Rusty", 90); 
			myCar.CrankTunes( true); try { 
				// Speed up car logic. 
			} catch( CarIsDeadException e) { 
				// Process CarIsDeadException. 
			} catch( ArgumentOutOfRangeException e) { 
				// Process ArgumentOutOfRangeException. 
			} catch( Exception e) { 
				// Process any other Exception. 
			} finally { 
				// This will always occur. Exception or not. 
				myCar.CrankTunes( false);

			} 
			Console.ReadLine(); 
		}
	}
}

