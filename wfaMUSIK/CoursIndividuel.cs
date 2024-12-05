using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaMUSIK
{
    public class CoursIndividuel :Cours
    {

        private Instrument lInstrument;

        public CoursIndividuel(int unIdCi, int unAgeMiniCi, List<Jour> desJoursCi, Instrument unInstrument)
            :base(unIdCi, unAgeMiniCi, desJoursCi)
        {
            
            this.lInstrument = unInstrument;
        }
        /// <summary>
        /// redifinition de la methode description pour le cours individuels
        /// </summary>
        /// <returns></returns>
        public string description()
        {
            string str = base.description();
            str += "cour de " + lInstrument.Intitule;

            return str;
        }
    }
}
