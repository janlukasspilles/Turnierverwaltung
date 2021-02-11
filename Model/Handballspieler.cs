using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierverwaltung
{
    public class Handballspieler : Spieler
    {
        #region Attributes
        private int _wurfStaerke;
        #endregion
        #region Properties
        public int WurfStaerke { get => _wurfStaerke; set => _wurfStaerke = value; }
        #endregion
        #region Constructors
        public Handballspieler()
        {

        }
        public Handballspieler(int wurfStaerke)
        {
            WurfStaerke = wurfStaerke;
        }
        public Handballspieler(string name, int wurfStaerke, bool spieltAktiv, int alter) : base(name, spieltAktiv, alter)
        {
            WurfStaerke = wurfStaerke;
        }
        #endregion
        #region Methods
        public override string GetInformation()
        {
            return base.GetInformation() + $"Wurfstärke: {WurfStaerke}\r\n\r\n";
        }
        #endregion
    }
}
