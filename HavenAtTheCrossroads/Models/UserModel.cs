namespace HavenAtTheCrossroads.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public enum RoleType
        {
            User,
            DM
        }
        public RoleType Role { get; set; }
        public int ConcurrencyId { get; set; }

        public static List<string> GetDms()
        {
            List<string> list = new List<string>();
            return list;
        }
    }
}
