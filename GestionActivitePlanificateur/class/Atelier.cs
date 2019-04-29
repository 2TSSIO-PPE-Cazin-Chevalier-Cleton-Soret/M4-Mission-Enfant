using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace GestionActivitePlanificateur
{

    class Enfant
    {
        protected String enfNom;
        protected String enfDescrpition;
        protected String enfHoraire;
        protected int enfNbrPlace;
        protected String enfPublicConcerne;

        public Enfant(String penfNom, String penfDescription, String penfHoraire, int penfNbrPlace, String penfPublicConcerne)
        {
            this.enfNom = penfNom;
            this.enfDescrpition = penfDescription;
            this.enfHoraire = penfHoraire;
            this.enfNbrPlace = penfNbrPlace;
            this.enfPublicConcerne = penfPublicConcerne;
        }

        public string getNom()
        {
            return this.enfNom;
        }

    }
}
