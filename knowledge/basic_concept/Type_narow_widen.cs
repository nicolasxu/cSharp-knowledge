using System;

namespace CSharpKnowledge
{
	public class Type_narow_widen
	{
		public Type_narow_widen ()
		{
			// 1. compailer will always detect type narrow error
			// 2. to void error, use explicit type cast ()
			//    This may cause data loss. 
		}

		public void check_overflow() {
			byte b1 = 100;
			byte b2 = 250;
			byte b3 = b1 + b2; // overflow!!!
			// since max value for byte is 256


			// solution
			try {
				
			} catch(OverflowException ex) {
				Console.WriteLine (ex.Message);
			}

		}

	}
}

