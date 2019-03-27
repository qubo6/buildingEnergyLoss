using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    public class Roof:Construction
    {
        public Roof(double area, List<Material> material) : base(area, material)
        {

        }
    }
}
