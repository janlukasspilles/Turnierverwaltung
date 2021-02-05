using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierverwaltung
{
    public class Physio : Teilnehmer
    {
        #region Attributes
        
        #endregion
        #region Properties
        #endregion
        #region Constructors
        public Physio()
        {

        }

        public Physio(string name) : base(name, "Physio")
        {

        }
        #endregion
        #region Methods
        public void SpielerFitMachen(Spieler s)
        {
            s.Verletzt = false;
        }
        #endregion
    }
}
