using MySql.Data.MySqlClient;
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
        private string _stadt;
        private string _gruendungsjahr;
        #endregion
        #region Properties
        public List<Teilnehmer> Mitglieder { get => _mitglieder; set => _mitglieder = value; }
        public string Stadt { get => _stadt; set => _stadt = value; }
        public string Gruendungsjahr { get => _gruendungsjahr; set => _gruendungsjahr = value; }
        #endregion
        #region Constructors
        public Mannschaft()
        {
            Mitglieder = new List<Teilnehmer>();
        }
        //public Mannschaft(string name) : base(name, "Mannschaft")
        //{
        //    Mitglieder = new List<Teilnehmer>();
        //}
        //public Mannschaft(string name, List<Teilnehmer> mitglieder) : base(name, "Mannschaft")
        //{
        //    Mitglieder = mitglieder;
        //}
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

        public override void Speichern()
        {
            string updateMannschaft = $"UPDATE SPIELER SET NAME='{Name}', STADT='{Stadt}', GRUENDUNGSJAHR='{Gruendungsjahr}' WHERE ID='{Id}'";            

            MySqlConnection Connection = new MySqlConnection("Server=127.0.0.1;Database=turnierverwaltung;Uid=user;Pwd=user;");
            Connection.Open();

            MySqlCommand command = new MySqlCommand
            {
                Connection = Connection
            };

            try
            {
                command.CommandText = updateMannschaft;
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Connection.Close();
            }
        }

        public override void SelektionId(long id)
        {
            MySqlConnection Connection = new MySqlConnection("Server=127.0.0.1;Database=turnierverwaltung;Uid=user;Pwd=user;");
            try
            {
                Connection.Open();

                string selektionstring = $"SELECT * FROM MANNSCHAFT WHERE ID = '{id}'";
                MySqlCommand command = new MySqlCommand(selektionstring, Connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Id = reader.GetInt64("ID");
                    Name = reader.GetString("NAME");
                    Stadt = reader.GetString("STADT");
                    Gruendungsjahr = reader.GetDateTime("GEBURTSTAG").ToString("yyyy-MM-dd");
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Connection.Close();
            }
        }
        #endregion
    }
}
