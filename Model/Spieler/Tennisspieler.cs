using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierverwaltung.Model.SpielerNS
{
    public class Tennisspieler : Spieler
    {
        #region Attributes
        private int _anzahlGewonneneSpiele;
        private int _anzahlSpiele;
        #endregion
        #region Properties
        public int AnzahlGewonneneSpiele { get => _anzahlGewonneneSpiele; set => _anzahlGewonneneSpiele = value; }
        public int AnzahlSpiele { get => _anzahlSpiele; set => _anzahlSpiele = value; }
        #endregion
        #region Constructors
        public Tennisspieler(string vorname, string nachname) : base(vorname, nachname)
        {
        }
        #endregion
        #region Methods
        public override string GetInformation()
        {
            return base.GetInformation();// + $"Schlagstärke: {AnzahlGewonneneSpiele}\r\n\r\n";
        }

        public override void SelektionId(long id)
        {
            MySqlConnection Connection = new MySqlConnection("Server=127.0.0.1;Database=turnierverwaltung;Uid=user;Pwd=user;");
            try
            {
                Connection.Open();

                string selektionstring = $"SELECT S.ID, TD.ANZAHL_GEWONNENE_SPIELE, TD.ANZAHL_SPIELE, S.VORNAME, S.NACHNAME, S.MANNSCHAFT_ID, S.GEBURTSTAG FROM SPIELER S JOIN HANDBALLER_DETAILS TD ON S.ID = TD.SPIELER_ID WHERE S.ID = {id}";
                MySqlCommand command = new MySqlCommand(selektionstring, Connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Id = reader.GetInt64("ID");
                    AnzahlGewonneneSpiele = reader.GetInt32("ANZAHL_GEWONNENE_SPIELE");
                    AnzahlSpiele = reader.GetInt32("ANZAHL_SPIELE");
                    Vorname = reader.GetString("VORNAME");
                    Nachname = reader.GetString("NACHNAME");
                    Mannschaft_id = reader.GetInt32("MANNSCHAFT_ID");
                    Geburtstag = reader.GetDateTime("GEBURTSTAG").ToString("yyyy-MM-dd");
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

        public override void Speichern()
        {
            string updateSpieler = $"UPDATE SPIELER SET VORNAME='{Vorname}', NACHNAME='{Nachname}', GEBURTSTAG='{Geburtstag}', MANNSCHAFT_ID='{Mannschaft_id}' WHERE ID='{Id}'";
            string updateDetails = $"UPDATE TENNIS_DETAILS SET ANZAHL_GEWONNENE_SPIELE='{AnzahlGewonneneSpiele}', ANZAHL_SPIELE='{AnzahlSpiele}' WHERE SPIELER_ID='{Id}'";

            MySqlConnection Connection = new MySqlConnection("Server=127.0.0.1;Database=turnierverwaltung;Uid=user;Pwd=user;");
            Connection.Open();
            //Transaction, da immer beide Tabellen ein Update benötigen. Wenn ein Update schief geht soll Rollback ausgeführt werden.
            MySqlTransaction transaction = Connection.BeginTransaction();

            MySqlCommand command = new MySqlCommand
            {
                Connection = Connection,
                Transaction = transaction
            };


            try
            {
                command.CommandText = updateSpieler;
                command.ExecuteNonQuery();
                command.CommandText = updateDetails;
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
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
