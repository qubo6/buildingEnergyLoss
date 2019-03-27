using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class Roof
    {
        public double Area { get; set; }

        private List<Material> MaterStrechy = new List<Material>();

        public Roof(double area, List<Material> materStrechy)
        {
            Area = area;
            MaterStrechy = materStrechy;
        }

        public double Calc()
        {
            double resistanceSum = 0;
            foreach (Material material in MaterStrechy)
            {
                resistanceSum += material.Width/ material.Lambda;
            }
            return (1 / resistanceSum) * Area;
        }
    }
}
