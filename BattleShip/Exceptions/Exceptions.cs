using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.Exceptions
{
	class BattleShipException : Exception
	{

		public BattleShipException() : base("A BattleShip Exception has occurred")
		{
			
		}

		public BattleShipException(string message) : base(message)
		{

		}
	}

	class ShipException : BattleShipException
	{
		public ShipException() : base("A Ship Exception has occurred")
		{

		}

		public ShipException(string message) : base(message)
		{

		}
	}

	class ShipPartOutOfBoundsException : BattleShipException
	{
		public ShipPartOutOfBoundsException() : base("A ShipPart Exception has occurred")
		{

		}

		public ShipPartOutOfBoundsException(string message) : base(message)
		{

		}


	}
}
