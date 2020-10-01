using System.Collections.Generic;

namespace AppSystem.Models
{
    public class Uf
    {
        public Uf()
        {
            Cities = new HashSet<City>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
