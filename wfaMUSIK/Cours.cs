using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace wfaMUSIK
{
     public class Cours 
    {
        protected int idCours;
        protected int ageMini;
        protected List<Jour> lesJours;
        private int idIntrument;

        /// <summary>
        /// definition du constructeur Cours
        /// </summary>
        /// <param name="unIdCours">retourne l'id du cours</param>
        /// <param name="unAgeMini">retourne l'age minimum</param>
        /// <param name="desJours">retourne la liste des jours</param>
        public Cours(int unIdCours, int unAgeMini, List<Jour> desJours)
        {
            this.idCours = unIdCours;
            this.ageMini = unAgeMini;
            this.lesJours = desJours;
        }

        public Cours(int unAgeMini, List<Jour> desJours)
        {
            this.idCours = 0;
            this.ageMini = unAgeMini;
            this.lesJours = desJours;
        }
        /// <summary>
        /// retourne la description d'un cour de musique
        /// </summary>
        /// <returns>chaîne de caratères</returns>
        public string description()
        {
            string str = "";
            str = "cour n°" + this.idCours + " à partir de " + this.ageMini + " ans";
            return str;
        }

        public Boolean aLieuLeJour(string jour)
        {
            Boolean bln = false;

            return bln;
        }

        public int identifiant
        {
            get
            {
                return this.idCours;
            }
        }
        public int age
        {
            get
            {
                return this.ageMini;
            }
            
        }

        public void enregistrer()
        {
            //connexion 
           


            //maj de la liste instrument

           
        }
    }
}
