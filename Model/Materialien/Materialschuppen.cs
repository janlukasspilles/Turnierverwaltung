using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnierverwaltung.Model.Materialien
{
    public class Materialschuppen
    {
        #region Attributes
        private List<Material> _materialien;
        #endregion
        #region Properties
        public List<Material> Materialien { get => _materialien; set => _materialien = value; }
        #endregion
        #region Constructors        
        public Materialschuppen()
        {
            Materialien = new List<Material>();
        }
        public Materialschuppen(List<Material> materialien)
        {
            Materialien = materialien;
        }
        #endregion
        #region Methods
        public Material MaterialAusgeben(string bezeichnung)
        {
            foreach (Material m in Materialien)
            {
                if(m.Bezeichnung == bezeichnung)
                {
                    Material res = m;
                    Materialien.Remove(m);
                    return res;
                }
            }
            throw new Exception($"Ein {bezeichnung} ist nicht mehr vorhanden.");
        }

        public void MaterialZurückgeben(Material m)
        {
            Materialien.Add(m);
        }
        #endregion
    }
}
