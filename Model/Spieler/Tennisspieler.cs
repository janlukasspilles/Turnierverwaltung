using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierverwaltung.Model.SpielerNS
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
        public Tennisspieler(string vorname, string nachname) : base(vorname, nachname)
        {
        }
        #endregion
        #region Methods
        public override string GetInformation()
        {
            return base.GetInformation() + $"Schlagstärke: {SchlagStaerke}\r\n\r\n";
        }

        public override void Speichern()
        {
            throw new NotImplementedException();
        }

        public override void SelektionId(long id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
