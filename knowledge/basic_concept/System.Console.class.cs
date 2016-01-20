using System;

namespace CSharpKnowledge
{
	public class Console_class
	{
		public Console_class ()
		{	/*
			the Console class encapsulates input, 
			output, and error-stream manipulations for console-based applications.
			*/
		}
	}

	class Members {
		public Members() {
			System.Console.Beep ();
			System.Console.BackgroundColor;
			System.Console.ForegroundColor;

			System.Console.BufferHeight;
			System.Console.BufferWidth;

			System.Console.Title; // title of console window
			System.Console.WindowHeight;
			System.Console.WindowWidth;
			System.Console.WindowLeft;
			System.Console.Clear ();
		}

	

	}

	class Writeline_Readline {
		public Writeline_Readline () {
			Console.WriteLine("Enter your name");
			string userName = Console.ReadLine ();

			Console.ForegroundColor = ConsoleColor.Yellow;

		}
	}

	class Format_output {
	
		public void Writeline() {
			// Prints: 20, 10, 30 
			Console.WriteLine("{ 1}, {0}, {2}", 10, 20, 30);

			Console.WriteLine(" c format: {0: c}", 99999); 
			// c format: $ 99,999.00

			Console.WriteLine(" d9 format: {0: d9}", 99999); 
			// d9 format: 000099999

			Console.WriteLine(" f3 format: {0: f3}", 99999);
			// f3 format: 99999.000

			Console.WriteLine(" n format: {0: n}", 99999);
			// n format: 99,999.00

			Console.WriteLine(" E format: {0: E}", 99999); 
			// E format: 9.999900E + 004

			Console.WriteLine(" e format: {0: e}", 99999); 
			// e format: 9.999900e + 004

			Console.WriteLine(" X format: {0: X}", 99999); 
			// X format: 1869F hexadecimal format

			Console.WriteLine(" x format: {0: x}", 99999);
			// x format: 1869f


		}
	
	}

	class String_format {
		public void format_example() {
			string userMessage = string.Format(" 100000 in hex is {0: x}", 100000);
			System.Windows.MessageBox.Show( userMessage);

		}
	}



}

