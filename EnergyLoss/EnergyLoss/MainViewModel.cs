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

        public List<int> IdRoof { get; set; } = new List<int>();
        public List<double> WidthRoof { get; set; } = new List<double>();
        public double AreaRoof { get; set; }

        public List<int> IdFloor { get; set; } = new List<int>();
        public List<double> WidthFloor { get; set; } = new List<double>();
        public double AreaFloor { get; set; }

        public List<int> IdWall { get; set; } = new List<int>();
        public List<double> WidthWall { get; set; } = new List<double>();
        public double AreaWall { get; set; }


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

        private Roof CreateRoof()
        {
            List<Material> materialRoof = new List<Material>();
            for (int i = 0; i < IdRoof.Count; i++)
            {
                materialRoof.Add(CreateMaterial(IdRoof[i], WidthRoof[i]));
            }
            return new Roof(AreaRoof, materialRoof);
        }

        public double CalculateRoof()
        {
           return CreateRoof().Calc();
        }
    }
}
