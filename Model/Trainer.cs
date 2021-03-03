﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierverwaltung.Model
{
    public class Trainer : Teilnehmer
    {
        #region Attributes
        private int _jahreErfahrung;
        private string _geburtstag;
        private string _vorname;
        private string _nachname;
        private long mannschaft_id;
        #endregion
        #region Properties
        public int JahreErfahrung { get => _jahreErfahrung; set => _jahreErfahrung = value; }
        public string Vorname
        {
            get => _vorname;
            set
            {
                _vorname = value;
                Name = Vorname + " " + Nachname;
            }
        }
        public string Nachname
        {
            get => _nachname;
            set
            {
                _nachname = value;
                Name = Vorname + " " + Nachname;
            }
        }

        public long Mannschaft_id { get => mannschaft_id; set => mannschaft_id = value; }
        public string Geburtstag { get => _geburtstag; set => _geburtstag = value; }
        #endregion
        #region Constructors
        public Trainer() : base()
        {

        }
        #endregion
        #region Methods
        public override string GetInformation()
        {
            return "";
        }

        public override bool Speichern()
        {
            throw new NotImplementedException();
        }

        public override void SelektionId(long id)
        {
            throw new NotImplementedException();
        }

        public override bool Neuanlage()
        {
            throw new NotImplementedException();
        }

        public override bool Loeschen()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
