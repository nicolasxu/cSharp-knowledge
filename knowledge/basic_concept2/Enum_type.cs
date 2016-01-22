using System;

namespace CSharpKnowledge
{
	public class Enum_type
	{
		public Enum_type ()
		{
			// Enum type is not IEnumerable
			// class that implement IEnumerable interface can work on foreach. 

		}

		// enum example:
		enum EmpType 
		{ Manager = 102, 
			Grunt =1, // = 103 
			Contractor = 5, // = 104 
			VicePresident // = 105 
		}
		public void enum_notes() {
			// 1. no need to have unique values.
			// 2. no need to have sequential ordering
			// 3. System.Int32 is default type for storing enum var
			// 4. Illegal to add to enum type after its definition

		}
		// example, no need to default type
		enum EmployeeType: byte {
			Manager = 10,
			Grunt = 1,
			Contractor = 100,
			VP = 9
		}
		public void enum_usage () {
			// 1. use as variable
			EmpType emp = EmpType.Contractor;
			// 2. get type
			Console.WriteLine(emp.GetType().Name);
			Console.WriteLine(emp.ToString());// output "Contractor"
			// 3. Enum.GetValues
			Array enumData = Enum.GetValues( emp.GetType());


		}

	}
}

