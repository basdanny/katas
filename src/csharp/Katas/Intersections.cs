using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class Intersections
	{

		public static void Do()
		{
			var carSet1 = new HashSet<string>()
			{
				"Subaru",
				"Mazda",
				"Audi",
				"Skoda",
				"Toyota",
				"Suzuki"
			};
		
			var carSet2 = new HashSet<string>()
			{
				"Subaru",
				"Mazda",
				"Audi",
				"Skoda",
				"Toyota",
				"Dodge",
				"Ford",
				"Ram"
			};

			var carsInSet1ButNotInSet2 = carSet1.Except(carSet2);
			PrintResult("carsInSet1ButNotInSet2", carsInSet1ButNotInSet2);

			var carsInBothSets = carSet1.Intersect(carSet2);
			PrintResult("carsInBothSets", carsInBothSets);

			var charactersInAnySet = carSet1.Union(carSet2);
			PrintResult("charactersInAnySet", charactersInAnySet);


			//(A union B) - (A intersect B)
			var union = carSet1.Union(carSet2);
			var intersect = carSet1.Intersect(carSet2);
			var symmetricDifference1 = union.Except(intersect);
			PrintResult("symmetricDifference1", symmetricDifference1);
		}

		private static void PrintResult(string msg, IEnumerable<string> result)
        {
			Console.WriteLine($"{msg}: {string.Join(",", result)}");
		}
	}

}
