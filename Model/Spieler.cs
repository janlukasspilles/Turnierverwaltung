using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierverwaltung
{
    public class Spieler : Teilnehmer
    {
        #region Attributes      
        private bool _spieltAktiv;
        private int _alter;
        #endregion
        #region Properties
        public bool SpieltAktiv { get => _spieltAktiv; set => _spieltAktiv = value; }
        public int Alter { get => _alter; set => _alter = value; }
        #endregion
        #region Constructors
        public Spieler() : base()
        {

        }        
        public Spieler(string name, bool spieltAktiv): base(name, "Spieler")
        {
            SpieltAktiv = spieltAktiv;
        }
        #endregion
        #region Methods
        public void Wechsel()
        {
            SpieltAktiv = !SpieltAktiv;
        }
        #endregion
    }
}
