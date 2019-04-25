using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
	class Program
	{
		static void Main(string[] args)
		{

			Map map = new Map(5);
			Console.WriteLine(map.PrintMap());

			Console.WriteLine("Press any key to exit");
			Console.ReadKey();
		}
	}
}
