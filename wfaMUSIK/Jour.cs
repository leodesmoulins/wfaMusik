using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaMUSIK
{
    public class Jour
    {
        /// <summary>
        /// attribut de la classe Jour
        /// </summary>
        private int idJour;
        private string libelleJour;


        /// <summary>
        /// Constructeur de la classe Jour
        /// </summary>
        /// <param name="unIdJour"></param>
        /// <param name="unLibelleJour"></param>
        public Jour(int unIdJour, string unLibelleJour)
        {
            this.idJour = unIdJour;
            this.libelleJour = unLibelleJour;
        }

        /// <summary>
        /// Accesseur de la classe Jour
        /// </summary>
        public int Id
        {
            get
            {
                return this.idJour;
            }
            set
            {
                this.idJour = value;
            }
        }
        public string Libelle
        {
            get
            {
                return this.libelleJour;
            }
            set
            {
                this.libelleJour = value;
            }
        } 
    }
}
