using System.ComponentModel.DataAnnotations;

namespace FlatPlanet.Data.Models
{
    public class ClickCounter
    {
        [Key]
        public int Id { get; set; }
        public int Counter { get; set; }    

    }
}
