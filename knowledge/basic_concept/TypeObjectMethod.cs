using System;

namespace CSharpKnowledge
{
	public class NumberObject
	{
		public void SomeMethods() {
			// All number object has MaxValue, MinValue member
			Console.WriteLine(" Min of double: {0}", double.MinValue);
			Console.WriteLine(" Min of double: {0}", double.MinValue);
			Console.WriteLine(" double.PositiveInfinity: {0}", double.PositiveInfinity);
			Console.WriteLine(" double.PositiveInfinity: {0}", double.NegativeInfinity);


			// member of System.Bool
			Console.WriteLine(" bool.TrueString: {0}", bool.TrueString);
			Console.WriteLine(" bool.FalseString: {0}", bool.FalseString);

			// member of System.Char
			char myChar = 'a';
			Console.WriteLine(" char.IsDigit(’ a’): {0}", char.IsDigit( myChar));

			char.IsDigit (myChar);
			char.IsLetter (myChar);
			char.IsWhiteSpace (myChar);
			char.IsPunctuation ('?');

		}

		public void Parse_value_from_string() {
			bool b = bool.Parse ("True");
			double d = double.Parse(" 99.884");
			int i = int.Parse("8");
			char c = Char.Parse("w");

		}
	}
}

