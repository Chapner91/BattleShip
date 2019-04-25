using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.Exceptions;

namespace BattleShip
{
	class Program
	{
		static void Main(string[] args)
		{

			try
			{
				Map map = new Map(7);
				Console.WriteLine(map.PrintMap());

				Ship cruiser = new Ship("cruiser", 3, new ShipPart[]
					{
					new ShipPart(1,1,map),
					new ShipPart(1,2,map),
					new ShipPart(1,3,map)

					});

				Ship carrier = new Ship("carrier", 5, new ShipPart[]
					{
						new ShipPart(2,0,map),
						new ShipPart(2,1,map),
						new ShipPart(2,2,map),
						new ShipPart(2,3,map),
						new ShipPart(2,4,map),
						new ShipPart()
					}
				);
			} catch (ShipPartOutOfBoundsException ex)
			{
				Console.WriteLine(ex.Message);
			} catch (ShipException ex)
			{
				Console.WriteLine(ex.Message);
			}

			Console.WriteLine("Press any key to exit");
			Console.ReadKey();
		}
	}
}
