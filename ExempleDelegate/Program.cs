// See https://aka.ms/new-console-template for more information
using ExempleDelegate;

Console.WriteLine("Hello, World!");

Radio maRadio = new Radio(Ecoute);
//Console.WriteLine(maRadio.Emettre());
maRadio.Connexion();
//if(maRadio.Abonnement!=null)
//{
//    maRadio.Abonnement("Le pirate est toujours là");
//}

void Ecoute(string message)
{
    Console.WriteLine(message);
}