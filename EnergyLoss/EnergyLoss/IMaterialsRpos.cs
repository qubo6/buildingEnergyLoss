using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    interface IMaterialsRepos
    {
        List<Material> GetMaterials();
        Material CreateMaterial(int ID, double width);
    }
}
