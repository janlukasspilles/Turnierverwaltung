using System;
using System.Collections.Generic;
using Turnierverwaltung.Model;
using Turnierverwaltung.Model.Materialien;
using Turnierverwaltung.Model.SpielerNS;
using Turnierverwaltung.ViewNS;

namespace Turnierverwaltung.ControllerNS
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
            Materialwart mat = new Materialwart("Frank", new List<Material>() { new Material("Fussball")});

            m.NeuesMannschaftsMitglied(f);
            m.NeuesMannschaftsMitglied(tr);
            m.NeuesMannschaftsMitglied(p);
            m.NeuesMannschaftsMitglied(h);
            m.NeuesMannschaftsMitglied(t);
            m.NeuesMannschaftsMitglied(mat);
            view.TextEinlesen(m.GetInformation());
            view.TextAusgeben();
            Console.ReadKey(true);
        }
        #endregion
    }
}
