using System;

namespace CSharpKnowledge
{
	public class When_keyword
	{
		public When_keyword ()
		{
			// When you add "when" clause, you have the ability to 
			// ensure that the statements within a catch block are
			// executed only if some condition in your code holds true.


			// when(expression), the expression must be evaluated only to true/false
		}
		public void example() {
		
			catch (CarIsDeadException e) when (e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday) {
				
				// This new line will only print if the when clause evaluates to true. 
				Console.WriteLine(" Catching car is dead!"); Console.WriteLine( e.Message); 
			}

		
		}
	}
}

