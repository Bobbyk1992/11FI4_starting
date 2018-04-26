using System;

namespace StartingPoint
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class MainClass
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Console.WriteLine("Hello you idiots");
			// Create movies
			Movie movCinderella = new Movie("Cinderella", PriceCodes.Childrens);
			Movie movStarWars = new Movie("Star Wars", PriceCodes.Regular);
			Movie movGladiator = new Movie("Gladiator", PriceCodes.NewRelease);
			Movie movHarryPotter = new Movie("HarryPotter", PriceCodes.NewRelease);

			// Create customers
			Customer custMickeyMouse = new Customer("Mickey Mouse");
			Customer custDonaldDuck = new Customer("Donald Duck");
			Customer custMinnieMouse = new Customer("Minnie Mouse");
			

			// Create rentals
			Rental rental1 = new Rental(movCinderella, 5);
			Rental rental2 = new Rental(movStarWars, 5);
			Rental rental3 = new Rental(movGladiator, 5);
			Rental rental4 = new Rental(movHarryPotter, 4);

			// Assign rentals to customers
			custMickeyMouse.AddRental(rental1);
			custMickeyMouse.AddRental(rental2);
			custMickeyMouse.AddRental(rental3);
			custDonaldDuck.AddRental(rental4);

			// Generate invoice
			string statement = custMickeyMouse.Statement();
			string statement2 = custDonaldDuck.Statement();

			// Print the statement
			Console.WriteLine(statement);
			Console.ReadLine();
			Console.WriteLine(statement2);
			Console.ReadLine();
		}
	}
}
