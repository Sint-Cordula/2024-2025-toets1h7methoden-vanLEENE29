namespace Toets1H7Methoden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VEEL SUCCES! 

            //declareren variabelen
            int aantalKarakters, pincode;

            //DEEL 1: pincode genereren
            Console.WriteLine("##### GENEREER PINCODE #####\n");

            //opvragen uit hoeveel cijfers de pincode moet bestaan
            Console.WriteLine("Uit hoeveel cijfers moet het wachtwoord bestaan?");
            aantalKarakters = Convert.ToInt32(Console.ReadLine());

            //pincode genereren op basis van zelf geschreven methode
            pincode = GetPincode(aantalKarakters);

            Console.WriteLine($"\nUw pincode: {pincode}\n");

            //DEEL 2: aanmelden
            Console.WriteLine("##### AANMELDEN MET PINCODE #####\n");

            //pincode opvragen
            Console.Write("Geef uw pincode op: ");
            int pincodeTest = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            //pincode controleren
            if (Aanmelden(pincode, pincodeTest))
            {
                Console.WriteLine("U bent succesvol aangemeld.");
            }
            else
            {
                Console.WriteLine("Foutieve pincode. Toegang geweigerd.");
            }



            public static int GetPincode(int aantalKarakters)
            {
                 Random random = new Random();
                 aantalKarakters = random.Next(1, 5);
                 return aantalKarakters;
            }
            public static bool Aanmelden(int pincode, int pincodeTest)
            {
                  bool result = false;

                  if (pincodeTest == pincode)
                  {
                      result = true;
                  }

                  return result;

            }

         }

    }

      
}
