namespace ApiMateriais.Models
{
    public class Material{
        public List<Material> Materiais { get; private set; }
        public string Nome { get; private set; } 
        public Guid Id { get; private set; }  
        public Estoque Estoque {get; set;} 
        private Material(){
            
        }        
        public Material(string nome, int quantidade)
        {   
            Id = Guid.NewGuid();
            Nome = nome;
            Materiais = new List<Material>();
            Estoque = new Estoque(quantidade);
        }
        public void AlterarNome(string newNome){
            Nome = newNome;
        }
    }
}