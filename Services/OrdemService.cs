using ApiMateriais.Exceptions;
using ApiMateriais.Models;
using ApiMateriais.Repository;

namespace ApiMateriais.Service
{
    public class OrdemService{
        private readonly OrdemRepository _ordemRepository = new OrdemRepository();
        public IEnumerable<Ordem> GetAllByStatus(EStatusOrdem statusOrdem){
           return _ordemRepository.GetAllByStatus(statusOrdem);
        } 

        public Ordem GetById(int id){
            return _ordemRepository.GetById(id);
        } 

        public void Create(Ordem ordem){
            _ordemRepository.Create(ordem);
        } 

        public void Delete(int id){
            
        }  

        public void Update(int id){
            
        } 
    }
}