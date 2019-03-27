using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class MaterialRepos : IMaterialsRepos
    {


        public List<Material> GetMaterials()
        {

            return _defineMaterials;
        }
        private List<Material> _defineMaterials = new List<Material>()
           {
                new Material() { Id = 0, Name = "",Lambda = 1 },
                new Material() { Id = 1, Name = "Ytong",Lambda = 0.09 },
                new Material() { Id = 2, Name = "Beton",Lambda = 1.74 },
                new Material() { Id = 3, Name = "Polystyren",Lambda = 0.03 },
                new Material() { Id = 4, Name = "Omietka",Lambda = 0.25 },
                new Material() { Id = 5, Name = "Sklená vata",Lambda = 0.039 },
                new Material() { Id = 6, Name = "Sadrokartón",Lambda = 0.34 }
           };


        public Material CreateMaterial(int ID, double width)
        {
            Material materialRoof = null;
            foreach (Material material in _defineMaterials)
            {               
                if (material.Id == ID)
                {
                    materialRoof = new Material()
                    {
                        Id = material.Id,
                        Lambda = material.Lambda,
                        Name = material.Name,
                        Width = width
                    };
                    break;
                }               
            }
            return materialRoof;
        }
    }
}

