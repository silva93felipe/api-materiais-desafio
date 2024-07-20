namespace ApiMateriais.Models
{
     public class Ordem{
        public int Id { get; set; }
        public DateTime SolicitadoEm {get; private set;}
        public EStatusOrdem Status { get; private set; }
        public Material Material { get; private set; }
        private Ordem(){
            SolicitadoEm = DateTime.Now;
            Status = EStatusOrdem.SOLICITADO;
        }
    }

    public enum EStatusOrdem
    {
        SOLICITADO,
        EMPRODUCAO,
        FINALIZADO
    }
}