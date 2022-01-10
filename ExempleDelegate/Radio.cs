using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleDelegate
{
    public delegate void DelEmission(string message); //Déclarer le prototype de mon delegate
    public  class Radio
    {
        private DelEmission Abonnement;
        public Radio(DelEmission FonctionEcoute)
        {
            Abonnement += FonctionEcoute;
        }

        public void Connexion()
        {
            Emettre();
        }
        
        private void Emettre()
        {
            if (Abonnement != null)
            {
                Abonnement("Bienvenue sur la Radio Technobel");
            }
           
        }

    }
}
