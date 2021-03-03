using System;
using System.Collections.Generic;
using Turnierverwaltung.Model;
using Turnierverwaltung.Model.SpielerNS;

namespace Turnierverwaltung.ControllerNS
{
    public class Controller
    {
        #region Attributes
        private List<Teilnehmer> _teilnehmer;
        #endregion
        #region Properties
        public List<Teilnehmer> Teilnehmer { get => _teilnehmer; set => _teilnehmer = value; }
        #endregion
        #region Constructors
        public Controller()
        {
            Teilnehmer = new List<Teilnehmer>();
            Fussballspieler f1 = new Fussballspieler
            {
                Vorname = "Peter",
                Nachname = "Zwegat",
                AnzahlTore = 10,
                Geburtstag = "1996-11-19",
                Mannschaft = "1. Fc Köln"
            };
            TeilnehmerHinzufuegen(f1);
            f1.AnzahlTore = 11;
            TeilnehmerAendern(f1);
            TeilnehmerLoeschen(f1);
        }
        #endregion
        #region Methods
        public bool TeilnehmerHinzufuegen(Teilnehmer t)
        {
            if (t.Neuanlage())
            {
                Teilnehmer.Add(t);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool TeilnehmerAendern(Teilnehmer t)
        {
            return t.Speichern();
        }
        public bool TeilnehmerLoeschen(Teilnehmer t)
        {
            if (t.Loeschen())
            {
                Teilnehmer.Remove(t);
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Teilnehmer> GetAlleTeilnehmer()
        {
            return _teilnehmer;
        }
        #endregion
    }
}
