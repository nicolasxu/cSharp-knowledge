using System;

namespace CSharpKnowledge
{
	public class Inner_exception
	{
		public Inner_exception ()
		{
			// definition: in the block of err handling,
			//             another exception is triggered.


			// 1. that the only way to document an inner exception is via a constructor parameter.

		}

		public void example () {

			catch (CarIsDeadException e) { 
				try { 
					FileStream fs = File.Open(@" C:\ carErrors.txt", FileMode.Open); 
						/* ... */
					} 
				catch (Exception e2) { 
					// Throw an exception that records the new exception, 
					// as well as the message of the first exception. 
					throw new CarIsDeadException( e.Message, e2); 
					// newException.InnerException will contain e2

				} 
			}


		}

	}
}

