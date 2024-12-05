using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaMUSIK
{
    public partial class frmGestionCours : Form
    {
        public frmGestionCours()
        {
            InitializeComponent();
        }

        private void frmGestionCours_Load(object sender, EventArgs e)
        {
            dvgCours.ColumnCount = 7;

            dvgCours.Columns[0].Name = "id";
            dvgCours.Columns[2].Name = "libelle";
            dvgCours.Columns[1].Name = "ageMini";
            dvgCours.Columns[3].Name = "ageMax";
            dvgCours.Columns[4].Name = "nbPlace";
            dvgCours.Columns[5].Name = "idInstrument";
            dvgCours.Columns[6].Name = "idTypeCours";

            foreach (Cours unCours in Program.ListeCours)
            {
                string[] uneLigne = {
                    unCours.identifiant.ToString(),
                    unCours.age.ToString(),
                     };
                dvgCours.Rows.Add(uneLigne);
            }

            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
