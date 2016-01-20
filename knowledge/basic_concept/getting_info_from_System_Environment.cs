using System;

namespace CSharpKnowledge
{
	public class getting_info_Environment_from_class
	{
		public getting_info_Environment_from_class ()
		{
		}

		static void ShowEnvironmentDetails() { 
			// Print out the drives on this machine, 
			// and other interesting details. 
			foreach (string drive in Environment.GetLogicalDrives()) 
				Console.WriteLine(" Drive: {0}", drive); 
			Console.WriteLine(" OS: {0}", Environment.OSVersion); 
			Console.WriteLine(" Number of processors: {0}", Environment.ProcessorCount); 
			Console.WriteLine(". NET Version: {0}", Environment.Version); 

			// other variables:
			/*
			ExitCode
			Is64BitOperationSystem
			MachineName
			NewLine
			SystemDirectory
			UserName
			Version
			*/
		}

			

		}
}

