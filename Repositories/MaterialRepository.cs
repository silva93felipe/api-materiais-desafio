using ApiMateriais.Models;

namespace ApiMateriais.Repository
{
    public class MaterialRepository{
        public static List<Material> Materials { get; set; } = new List<Material>();
        public MaterialRepository(){}
        public IEnumerable<Material> GetAll() => Materials;
        public Material GetById(Guid id){
            return Materials.Find(x => x.Id == id);
        } 

        public void Create(Material material){
            Materials.Add(material);
        } 

        public void Delete(Material material){
            Materials.Remove(material);
        }  

        public void Update(Guid id, Material material){
            
        } 
    }
}