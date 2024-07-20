namespace ApiMateriais.Exceptions
{
    public class MaterialNotFoundException : Exception{
        public MaterialNotFoundException() : base("Material not found")
        {
        }
    }
}