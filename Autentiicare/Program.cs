namespace Autentificare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string usernamecorect = "Crys";
            const string passwordcorect = "123crys";

            bool autentifacare = false;

            while (!autentifacare)
            {
                Console.WriteLine("Introduceti username: ");
                string username = Console.ReadLine();
                Console.WriteLine("Introduceti password: ");
                string password = Console.ReadLine();
                if (username == usernamecorect && password == passwordcorect)
                {
                    Console.WriteLine("Bine ai venit, " + usernamecorect);
                    autentifacare = true;
                }
                else
                {
                    Console.WriteLine("Autentificarea nu a putut fi procesata. Va rugam incercati din nou. ");

                }
            }
        }
    }
}