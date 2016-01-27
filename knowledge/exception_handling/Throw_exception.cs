using System;
using System.Collections;

namespace CSharpKnowledge
{
	public class Throw_exception
	{
		public Throw_exception ()
		{
			try {
				Exception ex = new Exception (String.Format("This is a exception"));
				ex.HelpLink = "http://www.help.com";
				ex.Data.Add ("TimeStamp", DateTime.Now);
				ex.Data.Add ("Cause", "You push too hard");
				throw ex;
			} catch (Exception e ) {
				foreach (DictionaryEntry de in e.Data) {
					Console.WriteLine ("{0} : {1}", de.Key, de.Value);
				}
			}
		

		}
	}
}

