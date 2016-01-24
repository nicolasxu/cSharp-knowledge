using System;

namespace CSharpKnowledge
{
	public class Sealed_keyword
	{
		public Sealed_keyword ()
		{
			// 1. if "Sealed", you can not extend this class.
		}
		public void many_system_class_is_sealed() {
			// e.g.: System.String

		}

		public void struct_is_always_sealed() {
			
		}
	}
	// example:
	public class Car {}
	sealed class MiniVan: Car {}

	class DeluxMiniVan: MiniVan {} // not allowed

}

