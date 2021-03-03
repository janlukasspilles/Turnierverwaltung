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
        #endregion
        #region Methods
        public override string GetInformation()
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

        public override bool Speichern()
        {
            bool res = true;
            string updateMannschaft = $"UPDATE MANNSCHAFT SET NAME='{Name}', STADT='{Stadt}', GRUENDUNGSJAHR='{Gruendungsjahr}' WHERE ID='{Id}'";

            MySqlConnection Connection = new MySqlConnection("Server=127.0.0.1;Database=turnierverwaltung2;Uid=user;Pwd=user;");
            Connection.Open();

            MySqlCommand command = new MySqlCommand
            {
                Connection = Connection
            };

            try
            {
                command.CommandText = updateMannschaft;
                res = command.ExecuteNonQuery() == 1;
            }
            catch (Exception)
            {
                res = false;
            }
            finally
            {
                Connection.Close();
            }
            return res;
        }

        public override void SelektionId(long id)
        {
            MySqlConnection Connection = new MySqlConnection("Server=127.0.0.1;Database=turnierverwaltung2;Uid=user;Pwd=user;");
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
                    Gruendungsjahr = reader.GetDateTime("GRUENDUNGSJAHR").ToString("yyyy-MM-dd");
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            finally
            {
                Connection.Close();
            }
        }

        public override bool Neuanlage()
        {
            bool res = true;
            string insertMannschaft = $"INSERT INTO MANNSCHAFT (NAME, STADT, GRUENDUNGSJAHR) VALUES ('{Name}', '{Stadt}', '{Gruendungsjahr}')";            

            MySqlConnection Connection = new MySqlConnection("Server=127.0.0.1;Database=turnierverwaltung2;Uid=user;Pwd=user;");
            Connection.Open();
            //Transaction, da immer beide Tabellen ein Update benötigen. Wenn ein Update schief geht soll Rollback ausgeführt werden.            

            MySqlCommand command = new MySqlCommand
            {
                Connection = Connection
            };

            try
            {
                command.CommandText = insertMannschaft;
                res = command.ExecuteNonQuery() == 1;                
                Id = command.LastInsertedId;
            }
            catch (Exception)
            {
                res = false;
            }
            finally
            {
                Connection.Close();
            }
            return res;
        }

        public override bool Loeschen()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
