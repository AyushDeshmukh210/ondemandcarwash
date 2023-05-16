using System.ComponentModel.DataAnnotations;

namespace OnDemandCarWash.Model.cs
{
    public class Addon
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { set; get; }
    }
}
