using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace wfaMUSIK
{
    static class Program
    {
        //variable globale
        public static List<Jour> ListeJour;
        public static List<Instrument> ListeInstrument;
        public static List<Cours> ListeCours;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ListeJour = new List<Jour>();
            ListeJour.Add(new Jour(1, "Lundi"));
            ListeJour.Add(new Jour(2, "Mardi"));
            ListeJour.Add(new Jour(3, "Mercredi"));
            ListeJour.Add(new Jour(4, "Jeudi"));
            ListeJour.Add(new Jour(5, "Vendredi"));
            ListeJour.Add(new Jour(6, "Samedi"));
            ListeJour.Add(new Jour(7, "Dimanche"));

            ListeInstrument = new List<Instrument>();

            ListeCours = new List<Cours>();
            using (SqlConnection cnxMusik = new SqlConnection(wfaMUSIK.Properties.Resources.ChaineConnexion))
            {
                cnxMusik.Open();
                MessageBox.Show("Connexion ok");

                string strSQL = "SELECT * FROM Instrument";
                SqlCommand cmd = new SqlCommand(strSQL, cnxMusik);
                SqlDataReader jeuEnr = cmd.ExecuteReader();
                
                while (jeuEnr.Read())
                {
                    int idInstru = int.Parse(jeuEnr[0].ToString());
                    string libInstru = jeuEnr[1].ToString();
                    ListeInstrument.Add(new Instrument(idInstru, libInstru));
                }
                jeuEnr.Close();
                strSQL = "SELECT * FROM cours";
                cmd = new SqlCommand(strSQL, cnxMusik);
                jeuEnr = cmd.ExecuteReader();

                while (jeuEnr.Read())
                {
                    int idCours = int.Parse(jeuEnr[0].ToString());
                    int ageMiniCours = int.Parse(jeuEnr[2].ToString());
                    int idTypeCours = int.Parse(jeuEnr[6].ToString());

                    if (idTypeCours == 1)
                    {
                        //cours individuel

                        int idInstrument = int.Parse(jeuEnr[5].ToString());

                        Instrument Linstrument = null;

                        foreach(Instrument unInstrument in ListeInstrument){
                            if(unInstrument.idInstru == idInstrument)
                            {
                                Linstrument = unInstrument;
                                break;
                            }
                        }

                        ListeCours.Add(new CoursIndividuel(idCours, ageMiniCours, new List<Jour>(), Linstrument));
                        
                    }
                    else
                    {
                        //Cours Collectif
                        string libCours = jeuEnr[1].ToString();
                        int ageMaxi = int.Parse(jeuEnr[3].ToString());
                        int nbPlace = int.Parse(jeuEnr[4].ToString());
                        ListeCours.Add(new CourCollectif(idCours, ageMiniCours, new List<Jour>(), libCours, ageMaxi, nbPlace));
                    }

                    //ListeCours.Add(new Cours(idCours, ageMiniCours, new List<Jour>()));
                }


                cnxMusik.Close();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmAccueil());
        }
    }
}
