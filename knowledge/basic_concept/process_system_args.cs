using System;

namespace CSharpKnowledge
{	
	class system_args {

		public system_args() {
			for ( int i = 0; i < args.Length; i ++) {
				Console.WriteLine(" Arg: {0}", args[ i]);
			}
			// or
			foreach (string arg in args) {
				Console.WriteLine (" Arg: {0}", arg);
			}
			// or
			//Get arguments using System.Environment. 
			string[] theArgs = Environment.GetCommandLineArgs(); 
			foreach (string arg in theArgs) {
				Console.WriteLine (" Arg: {0}", arg);
			}



		}

	}

}

