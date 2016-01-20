using System;

namespace CSharpKnowledge
{
	public class Named_argument
	{
		public Named_argument ()
		{
			// 1. all un-named arguments must come before named arguments. 
		}
		// example: 
		static void DisplayFancyMessage( ConsoleColor textColor, ConsoleColor backgroundColor, string message) { 
			// Store old colors to restore after message is printed. 
			ConsoleColor oldTextColor = Console.ForegroundColor;
			ConsoleColor oldbackgroundColor = Console.BackgroundColor;
			// Set new colors and print message. 
			Console.ForegroundColor = textColor; 
			Console.BackgroundColor = backgroundColor; 
			Console.WriteLine( message); // Restore previous colors. 
			Console.ForegroundColor = oldTextColor; 
			Console.BackgroundColor = oldbackgroundColor; 
		}

		// usage: 
		static void usage() {
			DisplayFancyMessage( message: "Wow! Very Fancy indeed!", 
				textColor: ConsoleColor.DarkRed, 
				backgroundColor: ConsoleColor.White);

			// This is OK, as positional args are listed before named args. 
			DisplayFancyMessage( ConsoleColor.Blue, message: "Testing...", backgroundColor: ConsoleColor.White);

			// This is an ERROR, as positional args are listed after named args. 
			// below is an error:
			// DisplayFancyMessage( message: "Testing...", backgroundColor: ConsoleColor.White, ConsoleColor.Blue);

		}



	}



}

