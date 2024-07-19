namespace ApiMateriais.Models
{
     public class Ordem{
        public Guid MaterialId { get; private set; }
        public int Quantidade { get; private set; }
        public Ordem()
        {
        }
    }
}