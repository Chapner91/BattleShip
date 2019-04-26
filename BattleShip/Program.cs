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

				Ship cruiser = new Ship("cruiser", 3, map, new Point(0, 0), "+y");
					

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
