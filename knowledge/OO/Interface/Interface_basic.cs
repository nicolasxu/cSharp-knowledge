using System;

namespace CSharpKnowledge
{
	public class Interface_basic
	{
		public Interface_basic ()
		{
			// 1. definition:
			//   Just a named set of abstract members.
			// 2. You can implement many interface in one class
			// 3. example: 
			//    IDbConnection IDbConnection interface defines a set of members that are common to all ADO.NET connection classes.

			// 4. abstract class VS interface class
			//    - interface can only contain definitions, whereas abstract class can
			//      can contain fields, constructors, any everything
			//    - abstract class and interface all can not be newed. 

			// 5. purpose of interface, polymorphism across the class.
			// 6. In extending class with abstract method, you have to implement it
			//    If using the interface, you can choose to implement the interface if it is 
			//    needed. 
			// 7. Implement interface, all or nothing proposition
			//    The supporting type is not able to selectively choose which 
			//    members it will implement.



		}


	}
	// example: 
	class Program { 
		static void Main( string[] args) 
		{ Console.WriteLine("***** A First Look at Interfaces *****\ n"); 
			// All of these classes support the ICloneable interface.
			string myStr = "Hello"; 
			OperatingSystem unixOS = new OperatingSystem( PlatformID.Unix, new Version()); 
			System.Data.SqlClient.SqlConnection sqlCnn = new System.Data.SqlClient.SqlConnection(); 
			// Therefore, they can all be passed into a method taking ICloneable.
			CloneMe( myStr); 
			CloneMe( unixOS); 
			CloneMe( sqlCnn); 
			Console.ReadLine(); 
		}
		private static void CloneMe( ICloneable c) { 
			// Clone whatever we get and print out the name.
			object theClone = c.Clone(); 
			Console.WriteLine(" Your clone is a: {0}", theClone.GetType(). Name); 
		} 
	}


}

