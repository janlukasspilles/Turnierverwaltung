using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierverwaltung
{
    public class Mannschaft : Teilnehmer
    {
        #region Attributes
        private List<Spieler> _mitglieder;
        #endregion
        #region Properties
        public List<Spieler> Mitglieder { get => _mitglieder; set => _mitglieder = value; }
        #endregion
        #region Constructors
        public Mannschaft()
        {
            Mitglieder = new List<Spieler>();
        }
        public Mannschaft(string name) : base(name, "Mannschaft")
        {
            Mitglieder = new List<Spieler>();
        }
        public Mannschaft(string name, List<Spieler> mitglieder) : base(name, "Mannschaft")
        {
            Mitglieder = mitglieder;
        }
        #endregion
        #region Methods
        public string AusgabeMannschaftsInformationen()
        {
            string res = $"Mannschaft: {Name}\r\n";
            foreach (Spieler s in Mitglieder)
            {
                res += $"Name: {s.Name}\r\nAlter: {s.Alter}\r\nSpielt gerade?: {(s.SpieltAktiv ? "Ja" : "Nein")}";
            }
            return res;
        }
        #endregion
    }
}
