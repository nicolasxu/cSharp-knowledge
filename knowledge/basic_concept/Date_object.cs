using System;

namespace CSharpKnowledge
{
	public class Date_object
	{
		public Date_object ()
		{
			DateTime thisDate1 = new DateTime (2015,6,10);
			Console.WriteLine ("date = " + thisDate1.ToString("MMMM dd yyyy"));
		}
	}
}

