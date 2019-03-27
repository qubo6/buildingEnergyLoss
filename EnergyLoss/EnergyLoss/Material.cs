using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Lambda { get; set; }
        public double Width { get; set; }
        //public Material(string Name, double Lambda)
        //{

        //}
        //public List<Material> materialList = new List<Material>();

        //public void CreateList()
        //{
        //    materialList.Add(new Material("Ytong", 0.09));
        //    materialList.Add(new Material("Beton", 1.74));
        //    materialList.Add(new Material("Polystyren", 0.03));
        //    materialList.Add(new Material("Omietka", 0.25));
        //    materialList.Add(new Material("Sklná vata", 0.039));
        //    materialList.Add(new Material("Sadrokartón", 0.34));

        //}       
    }
}
