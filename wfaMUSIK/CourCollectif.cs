using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaMUSIK
{
    public class CourCollectif :Cours
    {
        private string libelle;
        private int ageMaxi;
        private int nbPlaceMaxi;

        public CourCollectif(int unIdCl, int unAgeMiniCl, List<Jour> desJoursCl, string unLibelle, int unAgeMaxi, int unNbPlaceMaxi)
            :base(unIdCl, unAgeMiniCl, desJoursCl)
        {
            this.libelle = unLibelle;
            this.ageMaxi = unAgeMaxi;
            this.nbPlaceMaxi = unNbPlaceMaxi;
        }

        public string description()
        {
            string str = base.description();
            str += "Le cour s'apelle " + libelle + " l'age maximum est de " + ageMaxi + " ans et le nombre de place max est de " + nbPlaceMaxi;

            return str;
        }
        

       public int AgeMax
        {
            get
            {
                return this.ageMaxi;
            }
        }
        public int NombrePlaceMax
        {
            get
            {
                return this.nbPlaceMaxi;
            }
        }
        public string getLibelle
        {
            get
            {
                return this.libelle;
            }
        }
    }
}
