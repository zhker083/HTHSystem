namespace Models
{
    public class UserInfo
    {
        public string Account { get; set; }

        public string Password { get; set; }

        public UserPermission Permission { get; set; }
    }
}
