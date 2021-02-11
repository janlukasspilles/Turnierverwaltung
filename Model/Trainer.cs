using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierverwaltung
{
    public class Trainer : Teilnehmer
    {
        #region Attributes
        private int _jahreErfahrung;
        private char _trainerLizenz;
        #endregion
        #region Properties
        public int JahreErfahrung { get => _jahreErfahrung; set => _jahreErfahrung = value; }
        public char TrainerLizenz { get => _trainerLizenz; set => _trainerLizenz = value; }
        #endregion
        #region Constructors
        public Trainer()
        {

        }
        public Trainer(string name, int jahreErfahrung) : base(name, "Trainer")
        {
            JahreErfahrung = jahreErfahrung;
        }
        #endregion
        #region Methods
        public override string GetInformation()
        {
            return base.GetInformation() + $"Spielerfahrung in Jahren: {JahreErfahrung}\r\n\r\n";
        }
        #endregion
    }
}
