namespace ApiMateriais.Models
{
    public class Estoque{
        public Material Material { get; private set; }
        public int Quantidade { get; private set; }
        private Estoque(){}
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