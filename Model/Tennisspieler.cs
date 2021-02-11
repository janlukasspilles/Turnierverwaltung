using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierverwaltung
{
    public class Tennisspieler : Spieler
    {
        #region Attributes
        private int _schlagStaerke;
        #endregion
        #region Properties
        public int SchlagStaerke { get => _schlagStaerke; set => _schlagStaerke = value; }
        #endregion
        #region Constructors
        public Tennisspieler()
        {

        }
        public Tennisspieler(int schlagStaerke)
        {
            SchlagStaerke = schlagStaerke;
        }
        public Tennisspieler(string name, int schlagStaerke, bool spieltAktiv, int alter) : base(name, spieltAktiv, alter)
        {
            SchlagStaerke = schlagStaerke;
        }
        #endregion
        #region Methods
        public override string GetInformation()
        {
            return base.GetInformation() + $"Wurfstärke: {SchlagStaerke}\r\n\r\n";
        }
        #endregion
    }
}
