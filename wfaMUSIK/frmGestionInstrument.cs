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
    public partial class frmGestionInstrument : Form
    {
        public frmGestionInstrument()
        {
            InitializeComponent();
        }

        private void frmGestionInstrument_Load(object sender, EventArgs e)
        {
            dvgInstrument.ColumnCount = 2;

            dvgInstrument.Columns[0].Name = "id";
            dvgInstrument.Columns[1].Name = "Intitulé";

            foreach(Instrument unInstrument in Program.ListeInstrument)
            {
                string[] uneLigne = { unInstrument.idInstru.ToString(), unInstrument.Intitule.ToString() };
                dvgInstrument.Rows.Add(uneLigne);
            }
        }

        private void btnAddInstru_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddInstru_Click_1(object sender, EventArgs e)
        {
            AjoutInstrument AjoutInstrument = new AjoutInstrument();
            AjoutInstrument.Show();
        }
    }
}
