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
namespace NumbersGame
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while(true)
			{
				//skapar ett slumpmässigt tal som är det rätta talet
				Random random = new Random();
				int correctNumber = random.Next(1, 20);
				
				Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1 och 20. Kan du gissa vilket? Du får fem försök.");

				for (int i = 0; i < 5; i++)
				{
					if (int.TryParse(Console.ReadLine(), out int answer))
					{
						CheckGuess(answer, correctNumber);
					}
					else
					{
						Console.WriteLine("Du knappade inte in ett positivt tal.");
					}
				}
			}
		}
		static void CheckGuess(int answer, int correctNumber)
		{
			if (answer > correctNumber)
			{

			}
			else if (answer < correctNumber)
			{

			}
			else if (answer == correctNumber)
			{
				Console.WriteLine("Wohoo! Du klarade det!");
			}
		}
	}
}
