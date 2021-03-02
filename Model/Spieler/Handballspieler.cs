using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierverwaltung.Model.SpielerNS
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
        public Handballspieler(string vorname, string nachname) : base(vorname, nachname)
        {
        }
        #endregion
        #region Methods
        public override string GetInformation()
        {
            return base.GetInformation() + $"Wurfstärke: {WurfStaerke}\r\n\r\n";
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
