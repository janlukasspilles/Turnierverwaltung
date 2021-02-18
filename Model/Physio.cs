﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnierverwaltung.Model.SpielerNS;

namespace Turnierverwaltung.Model
{
    public class Physio : Teilnehmer
    {
        #region Attributes
        private char _lizenz;
        #endregion
        #region Properties
        public char Lizenz { get => _lizenz; set => _lizenz = value; }
        #endregion
        #region Constructors
        public Physio()
        {

        }

        public Physio(string name, char lizenz) : base(name, "Physio")
        {
            Lizenz = lizenz;
        }
        #endregion
        #region Methods
        public void SpielerFitMachen(Spieler s)
        {
            s.Verletzt = false;
        }

        public override string GetInformation()
        {
            return base.GetInformation() + $"Lizenz: { Lizenz} \r\n\r\n";
        }
        #endregion
    }
}
