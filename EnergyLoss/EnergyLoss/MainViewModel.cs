using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    public class MainViewModel
    {
        private IMaterialsRepos _materialRepos;
        public string Title { get; set; }
        public string Name { get; set; }
        public double NationType { get; set; }
        public double MinOutTemp { get; set; }
        public double HeatTemp { get; set; }
        public double BuildType { get; set; }
        //public List<Material> MaterialSteny = new List<Material>();
        //public List<Material> MaterialStrechy = new List<Material>();
        //public List<Material> MaterialPodlahy = new List<Material>();

        public MainViewModel()
        {
             _materialRepos = new MaterialRepos();
        }



        public List<Material> GetMaterials()
        {
            return _materialRepos.GetMaterials();
        }



        public Material CreateMaterial(int ID, double width)
        {
            return _materialRepos.CreateMaterial(ID,width);
        }


    }
}
