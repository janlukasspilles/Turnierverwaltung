using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierverwaltung
{
    public abstract class Spieler : Teilnehmer
    {
        #region Attributes      
        private bool _spieltAktiv;
        private int _alter;
        private bool _verletzt;
        #endregion
        #region Properties
        public bool SpieltAktiv { get => _spieltAktiv; set => _spieltAktiv = value; }
        public int Alter { get => _alter; set => _alter = value; }
        public bool Verletzt { get => _verletzt; set => _verletzt = value; }
        #endregion
        #region Constructors
        public Spieler() : base()
        {
            Verletzt = false;
            SpieltAktiv = true;
            Name = "Testplayer";
            Rolle = "Spieler";
        }        
        public Spieler(string name, bool spieltAktiv, int alter): base(name, "Spieler")
        {
            SpieltAktiv = spieltAktiv;
            Alter = alter;
            Verletzt = false;
        }
        public Spieler(string name, bool spieltAktiv, bool verletzt, int alter) : base(name, "Spieler")
        {
            SpieltAktiv = spieltAktiv;
            Verletzt = verletzt;
            Alter = alter;
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
