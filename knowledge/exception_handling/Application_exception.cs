using System;

namespace CSharpKnowledge
{
	// example: 
	public class CarIsDeadException : ApplicationException { 
		private string messageDetails = String.Empty; 
		public DateTime ErrorTimeStamp {get; set;} 
		public string CauseOfError {get; set;} 
		public CarIsDeadException(){} 
		public CarIsDeadException( string message, string cause, DateTime time) : base(message) { 
			messageDetails = message; 
			CauseOfError = cause; 
			ErrorTimeStamp = time; 

		} 
		// Override the Exception.Message property. 
		public override string Message { 
			get { return string.Format(" Car Error Message: {0}", messageDetails); }
		}
	}

}

