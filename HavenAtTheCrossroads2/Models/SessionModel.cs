using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HavenAtTheCrossroads.Models
{
    public class SessionModel
    {
        [Key]
        public int SessionId { get; set; }
        public string DM { get; set; } = "";

        public List<CharacterModel> Characters { get; set; } = new List<CharacterModel>();
        public List<MonsterModel> Monsters { get; set; } = new List<MonsterModel>();
        public List<SessionItemModel> AdHocs { get; set; } = new List<SessionItemModel>();
        public List<SessionItemModel> Items { get; set; } = new List<SessionItemModel>();

        public int Gold { get; set; }
        public int Exp { get; set; }
        public DateTime Date { get; set; }
        public string InGameDate { get; set; }

        public int ConcurrencyId { get; set; }

        /*public virtual IList<CharacterModel> ?Characters { get; set; }
        public virtual IList<MonsterModel> ?Monsters { get; set; }
        public virtual IList<SessionItemModel> ?AdHocs { get; set; }
        public virtual IList<SessionItemModel> ?Items { get; set; }*/

    }
}
