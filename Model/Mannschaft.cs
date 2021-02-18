using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierverwaltung.Model
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
        public new string GetInformation()
        {
            Mitglieder.Sort((a, b) => a.GetType().Name.CompareTo(b.GetType().Name));
            string res = $"Mannschaft: {Name}\r\n\r\n";
            foreach (Teilnehmer t in Mitglieder)
            {                
                res += t.GetInformation();
            }
            return res;
        }

        public void NeuesMannschaftsMitglied(Teilnehmer teilnehmer)
        {
            if (teilnehmer is Schiedsrichter)
                throw new Exception($"Ein {teilnehmer.GetType()} kann einer Mannschaft nicht beitreten!");  
            else
                Mitglieder.Add(teilnehmer);

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
