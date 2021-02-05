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
        private int _schussstaerke;
        #endregion
        #region Properties
        public int Schussstaerke { get => _schussstaerke; set => _schussstaerke = value; }
        #endregion
        #region Constructors
        public Fussballspieler()
        {

        }
        public Fussballspieler(int schussgeschwindigkeit)
        {
            Schussstaerke = schussgeschwindigkeit;
        }
        public Fussballspieler(string name, int schussstaerke, bool spieltAktiv) : base(name, spieltAktiv)
        {
            Schussstaerke = schussstaerke;
        }
        #endregion
        #region Methods
        public 
        #endregion
    }
}
