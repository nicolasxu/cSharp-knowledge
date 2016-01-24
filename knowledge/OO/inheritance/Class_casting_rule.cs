using System;

namespace CSharpKnowledge
{
	public class Class_casting_rule
	{
		public Class_casting_rule ()
		{
			// object -> Employee -> Manager
			//                    -> Sales -> PTSale

			// rule 1:
			// parent ancestor reference var1 can hold descendant object
			// var1 is implicist casted to descendant object. 

			// rule 2: 
			// Descendant type reference var2 can not refer to ancestor obj, 
			// or explicisit cast is required.
			//  explicit casting is evaluated at runtime,

			// e.g.:  object objRef = new Manager();
			//        Employee empRef = (Manager)objRef;


		}

		public void cast_error() {
			// cast will pass compiler, but result a runtime error if wrong cast
			// e.g. cast Frank to Hexgan, (Hexgan)frant
			object frank = new Manager(); 
			Hexagon hex; 
			try { 
				hex = (Hexagon) frank; 
			} catch (InvalidCastException ex) { 
				Console.WriteLine( ex.Message); 
			}
		}

		public void as_operator () {
			// trail cast, if not compatible, return null
			// Use "as" to test compatability. 
			object[] things = new object[ 4]; 
			things[ 0] = new Hexagon(); 
			things[ 1] = false; 
			things[ 2] = new Manager();
			things[ 3] = "Last thing"; 
			foreach (object item in things) { 
				Hexagon h = item as Hexagon; 
				if (h == null) 
					Console.WriteLine(" Item is not a hexagon"); 
				else { h.Draw(); 
				} 
			}


		}


			
		static void is_keyword( Employee emp) { 
			// objC is classB, return true, or return false. 
			Console.WriteLine("{ 0} was promoted!", emp.Name);
			if (emp is SalesPerson) { 
				Console.WriteLine("{ 0} made {1} sale( s)!", emp.Name, (( SalesPerson) emp). SalesNumber); 
				Console.WriteLine(); 
			} 
			if (emp is Manager) { 
				Console.WriteLine("{ 0} had {1} stock options...", emp.Name, (( Manager) emp). StockOptions); 
				Console.WriteLine(); 
			} 
		}


		
}

