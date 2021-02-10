using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierverwaltung
{
    public class Trainer : Teilnehmer
    {
        #region Attributes
        private int _jahreErfahrung;
        private string _mannschaft;
        #endregion
        #region Properties
        public int JahreErfahrung { get => _jahreErfahrung; set => _jahreErfahrung = value; }
        #endregion
        #region Constructors
        public Trainer()
        {

        }
        public Trainer(string name, int jahreErfahrung) : base(name, "Trainer")
        {
            JahreErfahrung = jahreErfahrung;
        }
        #endregion
        #region Methods
        #endregion
    }
}
