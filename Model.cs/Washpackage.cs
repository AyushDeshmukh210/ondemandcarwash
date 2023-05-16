using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace OnDemandCarWash.Model.cs
{
    public class Washpackage
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }

        [JsonIgnore]
        public IEnumerable<Addon> Addon { set; get; }
    }
}
