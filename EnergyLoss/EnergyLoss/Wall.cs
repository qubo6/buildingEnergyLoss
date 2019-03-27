using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class Wall : Construction
    {
        public Wall(double area, List<Material> material) : base(area, material)
        {

        }
    }
}
