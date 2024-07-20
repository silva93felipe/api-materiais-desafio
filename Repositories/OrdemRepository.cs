using ApiMateriais.Models;

namespace ApiMateriais.Repository
{
    public class OrdemRepository{
        public static List<Ordem> Ordens { get; set; } = new List<Ordem>();
        public OrdemRepository(){}
        public IEnumerable<Ordem> GetAllByStatus(EStatusOrdem statusOrdem) => Ordens.Where(e => e.Status == statusOrdem);
        public Ordem GetById(int id){
            return Ordens.Find(x => x.Id == id);
        } 

        public void Create(Ordem ordem){
            Ordens.Add(ordem);
        } 

        public void Delete(Ordem ordem){
            Ordens.Remove(ordem);
        }  

        public void Update(int id, Ordem ordem){
            
        } 
    }
}