using ApiMateriais.Models;
using ApiMateriais.Repository;

namespace ApiMateriais.Service
{
    public class MaterialService{
        private readonly MaterialRepository _materialRepository = new MaterialRepository();
        public IEnumerable<Material> GetAll(){
            return _materialRepository.GetAll();
        } 

        public Material GetById(Guid id){
            return _materialRepository.GetById(id);
        } 

        public void Create(string nome, int quantidade){
            Material material= new Material(nome, quantidade);
            _materialRepository.Create(material);
        } 

        public void Delete(Guid id){
            _materialRepository.Delete(id);
        }  

        public void Update(Guid id, string newNome){
            _materialRepository.Update(id, newNome);
        } 
    }
}