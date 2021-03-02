using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierverwaltung.Model.SpielerNS
{
    public abstract class Spieler : Teilnehmer
    {
        #region Attributes      
        private string _vorname;
        private string _nachname;
        private string _geburtstag;
        private int _mannschaft_id;
        #endregion
        #region Properties
        public string Vorname { get => _vorname; set => _vorname = value; }
        public string Nachname { get => _nachname; set => _nachname = value; }
        public string Geburtstag { get => _geburtstag; set => _geburtstag = value; }
        public int Mannschaft_id { get => _mannschaft_id; set => _mannschaft_id = value; }
        #endregion
        #region Constructors
        public Spieler(string vorname, string nachname) : base(vorname, nachname, "Spieler")
        {
        }
        #endregion
        #region Methods
        

        public override string GetInformation()
        {
            return base.GetInformation();// + $"Alter: { Alter}\r\nSpielt gerade: { (SpieltAktiv ? "Ja" : "Nein")}\r\nGesundheitsstatus: { (Verletzt ? "Verletzt" : "Gesund")}\r\n";
        }

        public abstract override void Speichern();
        public abstract override void SelektionId(long id);
        #endregion
    }
}
