using System.ComponentModel.DataAnnotations.Schema;

namespace pms.api.Model
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string color { get; set; }
        public decimal Price { get; set; }
    }
}
