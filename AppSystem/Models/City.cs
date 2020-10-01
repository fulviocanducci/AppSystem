namespace AppSystem.Models
{
    public class City
    {
        public int Id { get; set; }
        public int UfId { get; set; }
        public virtual Uf Uf { get; set; }
        public string Name { get; set; }
    }
}
