using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
	class ShipPart
	{
		public Point Location { get; }
		public bool IsHit { get; set; }
	
		
		public ShipPart(int x, int y)
		{
			IsHit = false;
			

		}
	}
}
