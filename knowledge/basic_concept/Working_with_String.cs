using System;

namespace CSharpKnowledge
{
	public class Working_with_String
	{
		/**
		Strings Are Immutable
		after you assign a string object with its initial value, 
		the character data cannot be changed.

		*/
		public void String_method ()
		{
			string firstName = "Freddy";
			Console.WriteLine(" firstName has {0} characters.", firstName.Length);
			Console.WriteLine(" firstName in uppercase: {0}", firstName.ToUpper());
			Console.WriteLine(" firstName contains the letter y?: {0}", firstName.Contains("y"));
			Console.WriteLine(" firstName after replace: {0}", firstName.Replace("dy", ""));

			// String Concatenation
			string s1 = "Programming the "; 
			string s2 = "PsychoDrill (PTP)"; 
			string s3 = s1 + s2; Console.WriteLine( s3);


		}

		public void escape_characters() {
			Console.WriteLine(" \' \" \\ \a \n \r \t  ");
			// \a is trigger a beep sound
		}
		public void do_not_process_escape() {
			string myString = @"c:\ndata\tdata";
			Console.WriteLine (myString);
			// result is "c:\ndata\tdata"

			// @ can also preserve the format of the string
			string message2 = @" line1
				line 2
				line 3";
			// if no @, here will be an error
		}

		public void const_string () {
			const string message = "abcdefg";
			if (message.Length > 10) {
				// ...
			}
		}
	}
}

