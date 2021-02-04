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
        public string Mannschaft { get => _mannschaft; set => _mannschaft = value; }
        #endregion
        #region Constructors
        public Trainer()
        {

        }
        public Trainer(string name, int JahreErfahrung, string mannschaft) : base(name, "Trainer")
        {
            Mannschaft = mannschaft;
        }
        #endregion
        #region Methods
        #endregion
    }
}
