using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierverwaltung
{
    public class Fussballspieler : Spieler
    {
        #region Attributes
        private double _schussgeschwindigkeit;
        #endregion
        #region Properties
        public double Schussgeschwindigkeit { get => _schussgeschwindigkeit; set => _schussgeschwindigkeit = value; }
        #endregion
        #region Constructors
        public Fussballspieler()
        {

        }
        public Fussballspieler(double schussgeschwindigkeit)
        {
            Schussgeschwindigkeit = schussgeschwindigkeit;
        }
        public Fussballspieler(string name, double schussgeschwindigkeit, bool spieltAktiv) : base(name, spieltAktiv)
        {
            Schussgeschwindigkeit = schussgeschwindigkeit;
        }
        #endregion
        #region Methods
        #endregion
    }
}
