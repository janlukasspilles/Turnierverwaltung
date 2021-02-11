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
        private List<Teilnehmer> _mitglieder;
        #endregion
        #region Properties
        public List<Teilnehmer> Mitglieder { get => _mitglieder; set => _mitglieder = value; }
        #endregion
        #region Constructors
        public Mannschaft()
        {
            Mitglieder = new List<Teilnehmer>();
        }
        public Mannschaft(string name) : base(name, "Mannschaft")
        {
            Mitglieder = new List<Teilnehmer>();
        }
        public Mannschaft(string name, List<Teilnehmer> mitglieder) : base(name, "Mannschaft")
        {
            Mitglieder = mitglieder;
        }
        #endregion
        #region Methods
        public string AusgabeMannschaftsInformationen()
        {
            Mitglieder.Sort((a, b) => a.GetType().FullName.CompareTo(b.GetType().FullName));
            string res = $"Mannschaft: {Name}\r\n\r\n";
            foreach (Teilnehmer t in Mitglieder)
            {
                res += t.GetInformation();                
            }
            return res;
        }

        public void NeuesMannschaftsMitglied(Teilnehmer teilnehmer)
        {
            if (teilnehmer is Trainer || teilnehmer is Spieler || teilnehmer is Physio)
                Mitglieder.Add(teilnehmer);
            else
                throw new Exception($"Ein {teilnehmer.GetType().ToString()} kann nicht einer Mannschaft beitreten!");
        }

        public Teilnehmer MitgliedVerlaesstMannschaft(string name)
        {
            foreach (Teilnehmer t in Mitglieder)
            {
                if (t.Name == name)
                {
                    Teilnehmer res = t;
                    Mitglieder.Remove(t);
                    return res;
                }
                else
                {
                    //Nichts
                }
            }
            throw new Exception("Kein Mitglied dieses Teams hat diesen Namen!");
        }
        #endregion
    }
}
