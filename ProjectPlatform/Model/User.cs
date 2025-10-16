namespace ProjectPlatform.Model
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }
        public double CompletionRateOfProjects { get; set; }
        public bool IsCommissioner { get; set; }
        public User(int id, string userName, string password, string email, DateTime joinDate, double completionRateOfProjects, bool isCommissioner)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Email = email;
            JoinDate = joinDate;
            CompletionRateOfProjects = completionRateOfProjects;
            IsCommissioner = isCommissioner;
        }



    }
}