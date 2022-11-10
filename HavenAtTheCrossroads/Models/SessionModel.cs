namespace HavenAtTheCrossroads.Models
{
    public class SessionModel
    {
        public int SessionId { get; set; }
        public string DM { get; set; } = "";
        
        public List<CharacterModel> ?Characters { get; set; }
        public List<SessionItemModel> ?Monsters { get; set; }
        public List<SessionItemModel> ?AdHocs { get; set; }
        public List<SessionItemModel> ?Items { get; set; }

        public int Gold { get; set; }
        public int Exp { get; set; }

        public int ConcurrencyId { get; set; }
    }
}
