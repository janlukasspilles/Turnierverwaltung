using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnierverwaltung.Model.Materialien;

namespace Turnierverwaltung.Model
{
    public class Materialwart : Teilnehmer
    {
        #region Attributes
        private List<Material> _materialien;
        #endregion
        #region Properties
        public List<Material> Materialien { get => _materialien; set => _materialien = value; }
        #endregion
        #region Constructors
        public Materialwart()
        {
            Materialien = new List<Material>();
        }

        public Materialwart(string name, List<Material> materialien) : base(name, "Materialwart")
        {
            Materialien = materialien;
        }
        #endregion
        #region Methods
        public override string GetInformation()
        {
            string resMats = "";
            foreach(Material m in Materialien)
            {
                resMats += m.GetInformation();
            }
            return base.GetInformation() + $"Materialien:\r\n{resMats}\r\n\r\n";
        }

        public void MaterialAusgeben()
        {

        }
        #endregion
    }
}
