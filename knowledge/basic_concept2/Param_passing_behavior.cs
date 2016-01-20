using System;

namespace CSharpKnowledge
{
	public class Param_passing_behavior
	{
		public Param_passing_behavior () {
			// default
			// out
			// ref
			// params
			// optional parameters

		}

		public void out_keyword() {
			// 1. It is an refernce, not copy
			// 2. Must assign value in the function, or compiler error. 
			// 3. Output parameters do not need to be initialized 
			//    before they passed to the method.
		}
		// out keyword example;
		static void Add( int x, int y, out int ans) { 
			ans = x + y; 
		}

		public void ref_keyword() {
			// 1. Reference parameters must be initialized before they are passed to the method.

		}
		// ref keyword example:
		public static void SwapStrings( ref string s1, ref string s2) { 
			string tempStr = s1;
			s1 = s2; 
			s2 = tempStr;
		}

		public void param_keyword() {
			// 1. Allow pass in an array of single type values
			// 2. Or allow pass in any number of single type value seperated by ","
			// 3. Compiler auto pack input into an array of that type
			// 4. Function only support one param keyword input, and it can only be the last input
		}
		// param keyword example: 
		static double CalculateAverage( params double[] values) {
			double sum = 0; 
			if( values.Length = = 0) return sum; 
			for (int i = 0; i < values.Length; i + +) 
				sum + = values[ i]; 
			return (sum / values.Length);

			// usage:
			// CalculateAverage( 4.0, 3.2, 5.7, 64.22, 87.2);
			// double[] data = { 4.0, 3.2, 5.7 }; 
			// int average = CalculateAverage( data);
			// CalculateAverage(); // result is 0
		}

		public void optional_params(string message = "default message") {
			// default value must be known at compiling time, runtime value doesn't work. 
			// below example doesn't work
			/*
			static void EnterLogData( string message, string owner = "Programmer", 
				DateTime timeStamp = DateTime.Now) {
				
			}
			*/

		}

	}
}

