using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    

namespace wfaMUSIK
{   
    public class Instrument
    {
        /// <summary>
        /// attribut de la classe Instrument
        /// </summary>
        private int idIntrument;
        private string intituleIntrument;


        /// <summary>
        /// Constructeur de la classe Instrument
        /// </summary>
        /// <param name="unIdInstru"></param>
        /// <param name="unIntitInstru"></param>
        public Instrument(int unIdInstru, string unIntitInstru)
        {
            this.idIntrument = unIdInstru;
            this.intituleIntrument = unIntitInstru;
        }

        /// <summary>
        /// Surcharge du constructeur de la classe instrument (l'objet n'est pas en bdd)
        /// </summary>
        /// <param name="unIntitInstru"></param>
        public Instrument(string unIntitInstru)
        {
            this.idIntrument = 0;
            this.intituleIntrument = unIntitInstru;
        }

        /// <summary>
        /// Accesseur de la classe Insrument
        /// </summary>
        public string Intitule
        {
            get
            {
                return this.intituleIntrument;
            }
            set
            {
                this.intituleIntrument = value;
            }
        }   
        public int idInstru 
        {
            get
            {
                return this.idIntrument;
            }
        }

        /// <summary>
        /// Enregistre l'objet courant en bdd
        /// </summary>
        public void enregistrer()
        {
            using (SqlConnection cnxMusik = new SqlConnection(wfaMUSIK.Properties.Resources.ChaineConnexion))
            {
                cnxMusik.Open();
                //string strSql = "INSERT INTO instrument(libelle) VALUES('"+ this.intitule +"')";

                //SqlCommand cmd = new SqlCommand(strSql, cnxMusik);
                //cmd.ExecuteNonQuery();

                SqlCommand cmd = new SqlCommand(null, cnxMusik);
                cmd.CommandText = "INSERT INTO instrument (libelle) VALUES(@lib)";

                SqlParameter libParam = new SqlParameter("@lib", System.Data.SqlDbType.NVarChar, 255);
                libParam.Value = this.intituleIntrument;

                cmd.Parameters.Add(libParam);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                string strSql = "Select Max(id) From Instrument";
                cmd = new SqlCommand(strSql, cnxMusik);
                SqlDataReader JeuEnr = cmd.ExecuteReader();

                JeuEnr.Read();

                int nouvelId = int.Parse(JeuEnr[0].ToString());
                this.idIntrument = nouvelId;
                cnxMusik.Close();
            }

            Program.ListeInstrument.Add(this);
        }
    }
}

