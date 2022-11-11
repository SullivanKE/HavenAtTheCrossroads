
using System.ComponentModel.DataAnnotations;

namespace HavenAtTheCrossroads.Models
{
    public class CharacterModel
    {
        [Key]
        public int UserId { get; set; }
        public int CharId { get; set; }
        public string Name { get; set; } = "";
        public int ConcurrencyId { get; set; }

    }
}
