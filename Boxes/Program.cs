using System;
using System.Collections.Generic;

namespace Boxes
{
	class MainClass
	{
		public static int GetValue(string name) {
			Console.Write(name);
			return Convert.ToInt32(Console.ReadLine());
		}

		public static void Main (string[] args)
		{

			List<Box> boxes = new List<Box> ();

			Console.WriteLine ("Hej! Velkommen til kasse-bygger 1.0 <tm>");
			do {
				Console.WriteLine ("Nu skal vi bygge en kasse!");
			
				int h = GetValue ("Højde? ");
				int w = GetValue ("Bredde? ");
				int d = GetValue ("Dybde? ");

				Box b = new Box (h, w, d);
				Console.Write ("Her er din kasse: ");
				Console.WriteLine (b);

				Console.WriteLine ("Volume = " + b.Volume ().ToString ());

				boxes.Add(b);

				Console.WriteLine("Vil du lave flere kasser? (y for ja)");
			} while (Console.Read() == 'y');


			Console.WriteLine ("Her er dine kasser:");
			int count = 0;
			foreach (Box b in boxes) {
				Console.WriteLine (b);
				count = count + 1;  // eller count++
			}
			Console.WriteLine ("I alt var der " + count + " kasser");


			Console.WriteLine ();
			Console.WriteLine ("Tryk en tast for at afslutte kasse-bygger 1.0!");
			Console.ReadKey ();
		}
	}
}
