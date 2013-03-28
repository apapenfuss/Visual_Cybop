using System;

namespace Visual_Cybop
{
	public class Modell
	{
		#region Private Properties

		private Guid _Id;
		private double _PosX;
		private double _PosY;
		private double _Width;
		private double _Height;
		private int _RelationType;
		private int _ChildIndex;
		private bool _HasRelation;
		private bool _HasChild;
		
		#endregion

		#region Public Properties

		public Guid Id {
			get { return _Id; } 
		}

		public double PosX {
			get { return _PosX; } 
			set
			{
				_PosX = value;
			}
		}

		public double PosY {
			get { return _PosY; } 
			set
			{
				_PosY = value;
			}
		}

		public double Width {
			get { return _Width; } 
			set
			{
				_Width = value;
			}
		}

		public double Height {
			get { return _Height; } 
			set
			{
				_Height = value;
			}
		}

		public int RelationType {
			get { return _RelationType; } 
			set
			{
				_RelationType = value;
			}
		}

		public int ChildIndex {
			get { return _ChildIndex; } 
			set
			{
				_ChildIndex = value;
			}
		}

		public bool HasRelation {
			get { return _RelationType > 0; } 
		}

		public bool HasChild {
			get { return _ChildIndex > 0; }		
		}

		#endregion

		public Modell ()
		{
			_PosX = 0;
			_PosY = 0;
			_Width = 0;
			_Height = 0;
		}

		public Modell (double posX, double posY, double width, double height)
		{
			_PosX = posX;
			_PosY = posY;
			_Width = width;
			_Height = height;
		}
	}
}

