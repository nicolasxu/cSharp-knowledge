using System;

namespace CSharpKnowledge
{
	public class ICloneable
	{
		public ICloneable ()
		{
		}
		// interface definition:
		public interface ICloneable { object Clone(); }

	}

	// The Point now supports "clone-ability." 
	public class Point : ICloneable { 
		public int X { get; set; } 
		public int Y { get; set; }
		public Point( int xPos, int yPos) {
			X = xPos;
			Y = yPos; 
		} 
		public Point() { } 
		// Override Object.ToString(). 
		public override string ToString() { 
			return string.Format(" X = {0}; Y = {1}", X, Y);
		} 
		// Return a copy of the current object. 
		public object Clone() { 
			return new Point( this.X, this.Y);
		} 
	}

	// deep clone
	// This class describes a point.
	public class PointDescription { 
		public string PetName {get; set;} 
		public Guid PointID {get; set;} 
		public PointDescription() {
			PetName = "No-name"; PointID = Guid.NewGuid(); 
		}
	}
	public class Point : ICloneable { 
		public int X { get; set; }
		public int Y { get; set; } 
		public PointDescription desc = new PointDescription();
		public Point( int xPos, int yPos, string petName) {
			X = xPos; Y = yPos; desc.PetName = petName; } 
		public Point( int xPos, int yPos) {
			X = xPos; Y = yPos; } 
		public Point() { }
		// Override Object.ToString().
		public override string ToString() { 
			return string.Format(" X = {0}; Y = {1}; Name = {2};\ nID = {3}\ n", X, Y, desc.PetName, desc.PointID);
		}

		public object Clone() {
			// First get a shallow copy. 
			Point newPoint = (Point)this.MemberwiseClone(); 
			// Then fill in the gaps. 
			PointDescription currentDesc = new PointDescription();
			currentDesc.PetName = this.desc.PetName;
			newPoint.desc = currentDesc;
			return newPoint; 
		}






}

