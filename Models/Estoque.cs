namespace ApiMateriais.Models
{
    public class Estoque{
        //public Guid MaterialId { get; private set; }
        public int Quantidade { get; private set; }
        public Estoque(int quantidade)
        {
            if(quantidade < 0){
                quantidade = 0;
            }
            Quantidade = quantidade;            
        }

        public void Adicionar(int quantidade){
            Quantidade += quantidade;
        }

        public void Retirar(int quantidade){
            Quantidade -= quantidade;
        }
    }
}