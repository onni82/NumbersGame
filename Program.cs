/*
 * ONNI BUCHT 
 * CHAS ACADEMY
 * .NET FULL STACK 2024
 * 
 * INSTRUKTIONER:
 * Skapa ett nytt projekt i Visual Studio (Console Application → C# → .Net Core)
 * Döp projektet till "NumbersGame".
 * När programmet startar ska följande skrivas ut i konsollen:
 * "Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök."
 * 
 * Programmet ska slumpa fram ett tal som användaren ska gissa på men såklart inte skriva ut vilket tal det är.
 * Förslagsvis genererar programmet ett tal mellan 1 och 20 men du får välja.
 * 
 * Användaren ska sedan mata in ett tal som den vill gissa på.
 * 
 * Om talet är fel ska programmet svara med antingen
 * "Tyvärr, du gissade för lågt!" eller "Tyvärr, du gissade för högt!" beroende på om talet som användaren gissade på var just högre eller lägre än det rätta.
 * 
 * Om användaren gissar rätt ska programmet skriva ut "Wohoo! Du klarade det!"
 * 
 * Om användaren har gissat fem (5) gånger och inte fått till rätt tal ska programmet skriva ut
 * "Tyvärr, du lyckades inte gissa talet på fem försök!" och användaren får inte gissa mer.
 * 
 * Någon del av din kod ska vara i en egen funktion/metod. Exempelvis kan du ha en funktion för att kolla om gissningen är rätt eller fel som heter CheckGuess().
 */
using System.Numerics;

namespace NumbersGame
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while(true)
			{
				// initierar Random-klassen och max antal försök och högsta möjliga tal
				Random random = new Random();
				int amountOfTries = 0;
				int maxValue = 0;

				// välkomnar användaren och låter denne välja svårighetsgrad
				Console.WriteLine("Välkommen! Välj svårighetsgrad:");
				Console.WriteLine("(1) Enkel nivå");
				Console.WriteLine("(2) Medelsvår nivå");
				Console.WriteLine("(3) Svår nivå");
				switch(Console.ReadLine())
				{
					case "1":
						amountOfTries = 6;
						maxValue = 10;
						break;
					case "2":
						amountOfTries = 5;
						maxValue = 25;
						break;
					case "3":
						amountOfTries = 3;
						maxValue = 50;
						break;

				}

				// skapar ett slumpmässigt tal (baserat på svårighetsgrad) som är det rätta talet
				int correctNumber = random.Next(1, maxValue);
				Console.WriteLine($"Jag tänker på ett nummer mellan 1 och {maxValue}. Kan du gissa vilket? Du får {amountOfTries} försök.");

				// ger användaren fem försök
				for (int i = 0; i < amountOfTries; i++)
				{
					if (int.TryParse(Console.ReadLine(), out int answer))
					{
						// kollar om användaren gissade rätt
						// om det är rätt blir det true och for-loopen avslutas
						if (CheckGuess(answer, correctNumber, i, amountOfTries) == true)
						{
							break;
						}
					}
					else
					{
						Console.WriteLine("Du knappade inte in ett positivt tal.");
					}
				}

				// kollar om användaren vill spela igen
				Console.Write("Vill du spela igen? J/N: ");
				if(Console.ReadLine().ToUpper() == "N")
				{
					break;
				}
			}
		}
		static bool CheckGuess(int answer, int correctNumber, int tries, int maxTries)
		{
			// sätter ett standard returnvärde för att inte få error
			bool result = false;

			//om användaren inte lyckas på fem försök
			//variabeln tries är antalet försök och har ett index på 0
			if ((answer != correctNumber) && (tries == maxTries-1))
			{
				Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
				result = false;
			}
			else if (answer > correctNumber)
			{
				Console.WriteLine("Tyvärr, du gissade för högt!");
				result = false;
			}
			else if (answer < correctNumber)
			{
				Console.WriteLine("Tyvärr, du gissade för lågt!");
				result = false;
			}
			else if (answer == correctNumber)
			{
				Console.WriteLine("Wohoo! Du klarade det!");
				result = true;
			}
			return result;
		}
	}
}
