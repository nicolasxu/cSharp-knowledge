using System;

namespace CSharpKnowledge
{
	// example:
	class Employee { 
		// Field data. 
		private string empName; 
		private int empID; 
		private float currPay; 
		// Properties! 
		public string Name {
			get { return empName; } 
			set { 
				if (value.Length > 15) 
					Console.WriteLine(" Error! Name length exceeds 15 characters!"); 
				else empName = value; 
			} 
		}
		public int ID { 
			get { return empID; } 
			set { empID = value; } 
		} 
		public float Pay { 
			get { return currPay; } 
			set { currPay = value; } 
		}
		// usage:
		/*
		Employee emp = new Employee(" Marvin", 456, 30000); 

		emp.Name = "Marv";
		*/
	}

