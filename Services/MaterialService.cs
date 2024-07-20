using ApiMateriais.Exceptions;
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
            Material material = new Material(nome, quantidade);
            _materialRepository.Create(material);
        } 

        public void Delete(Guid id){
            var material = GetById(id);
            if(material == null)
                throw new MaterialNotFoundException();
            _materialRepository.Delete(material);
        }  

        public void Update(Guid id, string nome){
            var material = GetById(id);
            if(material == null)
                throw new MaterialNotFoundException();
            _materialRepository.Update(id, material);
        } 
    }
}