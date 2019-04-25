using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.Exceptions;

namespace BattleShip
{
	class ShipPart
	{
		public Point Location { get; }
		public bool IsHit { get; private set; }
	
		
		public ShipPart(int x, int y, Map map)
		{
			IsHit = false;
			Location = new Point(x, y);

			if(!map.IsOnMap(Location))
			{
				throw new ShipPartOutOfBoundsException("A shipPart was created that is not on the map");
			}
		}

		public void HitShipPart()
		{
			IsHit = true;
		}
	}
}
