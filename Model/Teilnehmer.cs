//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        Controller.cs
//Datum:        19.11.2020
//Beschreibung: Kümmert sich um den Programmablauf
namespace Turnierverwaltung.Model
{
    public abstract class Teilnehmer
    {
        #region Attributes
        private string _name;
        private string _rolle;
        #endregion
        #region Properties
        public string Name { get => _name; set => _name = value; }
        public string Rolle { get => _rolle; set => _rolle = value; }
        #endregion
        #region Constructors
        public Teilnehmer()
        {

        }

        public Teilnehmer(string vorname, string nachname, string rolle)
        {
            Name = nachname;
            Rolle = rolle;
        }

        public Teilnehmer(Teilnehmer teilnehmer)
        {
            Name = teilnehmer.Name;
            Rolle = teilnehmer.Rolle;
        }
        #endregion
        #region Methods
        public virtual string GetInformation()
        {
            return $"{GetType().Name}\r\nName: {Name}\r\n";
        }

        public abstract void Speichern();
        public abstract void SelektionId(long id);
        #endregion
    }
}
