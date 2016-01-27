using System;

namespace CSharpKnowledge
{
	public class Rethrowing_exception
	{
		public Rethrowing_exception ()
		{
			// 1. throw; no argument only re-throw original exception
			// 2. Typically, you would only rethrow a partial handled exception to a caller
			//    that has the ability to handle the incoming exception more gracefully.

		}

		public void example() {
		
		
			{ /*...*/ try { 
					// Speed up car logic... 
				} catch( CarIsDeadException e) { 
					// Do any partial processing of this error and pass the buck. 
					throw; 
				} /*... */
			}



		
		}
	}
				
}

