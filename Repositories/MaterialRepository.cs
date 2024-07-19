using ApiMateriais.Models;

namespace ApiMateriais.Repository
{
    public class MaterialRepository{
        public static List<Material> Materials { get; set; } = new List<Material>();
        public MaterialRepository(){}
        public IEnumerable<Material> GetAll(){
            return Materials;
        } 

        public Material GetById(Guid id){
            return Materials.Find(x => x.Id == id);
        } 

        public void Create(Material material){
            Materials.Add(material);
        } 

        public void Delete(Guid id){
            Material material = Materials.Find(x => x.Id ==id);
            if(material != null) Materials.Remove(material);
        }  

        public void Update(Guid id, string newNome){
            Material material = Materials.Find(x => x.Id ==id);
            if(material != null){
                material.AlterarNome(newNome);
            }
        } 
    }
}