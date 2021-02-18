using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierverwaltung.Model.Materialien
{
    public class Material
    {
        #region Attributes
        private string _bezeichnung;
        private Zustand _zustand;
        #endregion
        #region Properties
        public string Bezeichnung { get => _bezeichnung; set => _bezeichnung = value; }
        public Zustand Zustand { get => _zustand; set => _zustand = value; }
        #endregion
        #region Constructors
        public Material(string bezeichnung)
        {
            _bezeichnung = bezeichnung;
        }
        public Material(string bezeichnung, Zustand zustand)
        {
            _bezeichnung = bezeichnung;
            _zustand = zustand;
        }
        #endregion
        #region Methods
        public string GetInformation()
        {
            return $"{Bezeichnung} => Qualität: {Zustand}\r\n";
        }
        #endregion
    }

    public enum Zustand
    {
        Neu,
        Gut,
        Mittel,
        Schlecht,
        Kaputt
    }
}
