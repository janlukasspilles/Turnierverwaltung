using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierverwaltung
{
    public class Controller
    {
        #region Attributes
        #endregion
        #region Properties
        #endregion
        #region Constructors
        public Controller()
        {
            Testdaten();
        }
        #endregion
        #region Methods
        public void Testdaten()
        {
            View view = new View();
            Mannschaft m = new Mannschaft("Vfl Rheinbach");
            Fussballspieler f = new Fussballspieler("Hans", 50, true, 25);
            Handballspieler h = new Handballspieler("Peter", 50, true, 40);
            Tennisspieler t = new Tennisspieler("Uwe", 50, true, 14);
            Trainer tr = new Trainer("Wilhelm", 30);
            Physio p = new Physio("Dennis", 'A');

            m.NeuesMannschaftsMitglied(f);
            m.NeuesMannschaftsMitglied(tr);
            m.NeuesMannschaftsMitglied(p);
            m.NeuesMannschaftsMitglied(h);
            m.NeuesMannschaftsMitglied(t);
            view.TextEinlesen(m.AusgabeMannschaftsInformationen());
            view.TextAusgeben();
            Console.ReadKey(true);
        }
        #endregion
    }
}
