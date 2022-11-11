
using System.ComponentModel.DataAnnotations;

namespace HavenAtTheCrossroads.Models
{
    public class SessionItemModel
    {
        [Key]
        public int SessionId { get; set; }
        public string Name { get; set; } = "";
        public int Value { get; set; }

        public enum ItemType {
            Monster,
            Adhoc,
            Item
        }
        public ItemType Type { get; set; } 
    }
}
