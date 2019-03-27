using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    public class Construction
    {
        public double Area { get; set; }

        private List<Material> Materials = new List<Material>();

        public Construction(double area, List<Material> material)
        {
            Area = area;
            Materials = material;
        }

       
        public double Calc(double tempDiff)
        {
            double resistanceSum = 0;
            foreach (Material material in Materials)
            {
                resistanceSum += (material.Width*0.01) / material.Lambda;
            }
            return (1 / resistanceSum) * Area*tempDiff;
        }
    }
}
