using System;

namespace CSharpKnowledge
{	
	// example:
	class Employee {
		// below is the constructor of Employee class
		public Employee( string name, int age, int id, float pay) { 
			// Better! Use properties when setting class data. 
			// This reduces the amount of duplicate error checks. 
			Name = name; 
			Age = age; 
			ID = id; 
			Pay = pay; 
		}
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
			set { empID = value; }  // if you remove the set, it is a read only property
		} 
		public float Pay { 
			get { return currPay; } 
			set { currPay = value; } 
		}
		public int Age {
			get { return currAge; }
			set { currAge = value; }
		}
	}


}

