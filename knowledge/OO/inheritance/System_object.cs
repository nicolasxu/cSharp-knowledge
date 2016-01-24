using System;

namespace CSharpKnowledge
{
	public class System_object
	{
		public System_object ()
		{
			// Finalize (); free memory
			// GetHashCode();
			// ToString();
			// GetType();
			// MeberwiseClone()
		}

		public void Equals() {
			// Equals() instance method, not static method
			// check if reference is the same, not actual content
		}

		public void override_keyword() {
			// you can override some of the method in System.Object
		}
		public void static_method() {
			Person p3 = new Person(" Sally", "Jones", 4); 
			Person p4 = new Person(" Sally", "Jones", 4);
			Console.WriteLine(" P3 and P4 have same state: {0}", object.Equals( p3, p4)); 
			Console.WriteLine(" P3 and P4 are pointing to same object: {0}", object.ReferenceEquals( p3, p4));

			object.Equals( p3, p4)); // check content equal, different from object.Equals()
			object.ReferenceEquals( p3, p4)); // check refernece equal

		}

	}
	// override object Equals() example: 
	public override bool Equals( object obj) { 
		if(obj is Person && obj != null) { 
			Person temp; 
			temp = (Person) obj; 
			if (temp.FirstName == this.FirstName && 
				temp.LastName == this.LastName && 
				temp.Age == this.Age) { 
				return true; } else { 
				return false; 
			} 
		} 
		return false; 
	}



}

