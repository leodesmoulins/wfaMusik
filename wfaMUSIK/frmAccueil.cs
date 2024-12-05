using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace wfaMUSIK
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            //using (SqlConnection cnxMusik = new SqlConnection(wfaMUSIK.Properties.Resources.ChaineConnexion))
            //{
            //    cnxMusik.Open();
            //    MessageBox.Show("Connexion ok");
            //    cnxMusik.Close();
            //}

            dvgCoursCollectif.ColumnCount = 6;

            dvgCoursCollectif.Columns[0].Name = "id";
            dvgCoursCollectif.Columns[2].Name = "libelle";
            dvgCoursCollectif.Columns[1].Name = "ageMini";
            dvgCoursCollectif.Columns[3].Name = "ageMax";
            dvgCoursCollectif.Columns[4].Name = "nbPlace";

            dvgCoursIndividuel.ColumnCount = 3;

            dvgCoursIndividuel.Columns[0].Name = "id";
            dvgCoursIndividuel.Columns[1].Name = "Age Mini";
            dvgCoursIndividuel.Columns[2].Name = "libelle cour";

            foreach (Cours unCours in Program.ListeCours)
            {
                
                

                if (unCours is CourCollectif)
                {
                    CourCollectif unCourCol = (CourCollectif)unCours;
                        string[] uneLigne = {
                            unCours.identifiant.ToString(),
                            unCours.age.ToString(),
                            unCourCol.getLibelle.ToString(),
                            unCourCol.AgeMax.ToString(),
                            unCourCol.NombrePlaceMax.ToString(),
                            

                     };
                    dvgCoursCollectif.Rows.Add(uneLigne);
                }
                else
                {
                    CoursIndividuel unCourIndi = (CoursIndividuel)unCours;
                    string[] uneLignes =
                    {
                        unCours.identifiant.ToString(),
                        unCours.age.ToString(),
                        unCourIndi.description()
                    };
                    dvgCoursIndividuel.Rows.Add(uneLignes);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGestionInstrument frmGestionInstrument = new frmGestionInstrument();
            frmGestionInstrument.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmGestionCours frmGestionCours = new frmGestionCours();
            frmGestionCours.Show();
        }
    }
}
