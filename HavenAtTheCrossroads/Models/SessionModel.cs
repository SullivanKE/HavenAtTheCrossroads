namespace HavenAtTheCrossroads.Models
{
    public class SessionModel
    {
        public int SessionId { get; set; }
        public string DM { get; set; } = "";

        /*public List<CharacterModel> Characters { get; set; } = new();
        public List<MonsterModel> Monsters { get; set; } = new();
        public List<SessionItemModel> AdHocs { get; set; } = new();
        public List<SessionItemModel> Items { get; set; } = new();*/

        public int Gold { get; set; }
        public int Exp { get; set; }

        public int ConcurrencyId { get; set; }

        public virtual IList<CharacterModel> ?Characters { get; set; }
        public virtual IList<MonsterModel> ?Monsters { get; set; }
        public virtual IList<SessionItemModel> ?AdHocs { get; set; }
        public virtual IList<SessionItemModel> ?Items { get; set; }

    }
}
