using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierverwaltung.Model.SpielerNS
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
        public Fussballspieler(int schussstaerke)
        {
            Schussstaerke = schussstaerke;
        }
        public Fussballspieler(string name, int schussstaerke, bool spieltAktiv, int alter) : base(name, spieltAktiv, alter)
        {
            Schussstaerke = schussstaerke;
        }
        #endregion
        #region Methods
        public double Schuss()
        {
            if (SpieltAktiv)
            {
                Random r = new Random();
                return Schussstaerke * r.NextDouble();
            }
            throw new Exception("Spieler kann nicht schießen!");
        }

        public override string GetInformation()
        {
            return base.GetInformation() + $"Schussstärke: {Schussstaerke}\r\n\r\n";
        }
        #endregion
    }
}
