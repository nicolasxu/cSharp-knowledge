using System;

namespace CSharpKnowledge
{
	public class System_exception
	{
		public System_exception ()
		{
			// 1. System exception is thrown by .Net

			// 2. determine System.SystemException
			// True! NullReferenceException is-a SystemException. 
			NullReferenceException nullRefEx = new NullReferenceException();
			Console.WriteLine(" NullReferenceException is-a SystemException? : {0}", 
				nullRefEx is SystemException); // if ancestor, then true, or false
			
		}
	}
}

