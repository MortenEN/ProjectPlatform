namespace ProjectPlatform.Model
{
    public class Project
    {
        public enum ProjectStatus { Accepted = 1, Initiated = 2, Working = 3, Completed = 4 }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User Owner { get; }
        public int PrecentageToCompletion { get; set; }
        public ProjectStatus Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<Item> ListOfItems { get; }
        public Project(int id, string title, string description, User owner, int precentageToCompletion, ProjectStatus status, DateTime startDate, List<Item> listOfItems, DateTime? endDate = null)
        {
            Id = id;
            Title = title;
            Description = description;
            Owner = owner;
            PrecentageToCompletion = precentageToCompletion;
            Status = status;
            StartDate = startDate;
            EndDate = endDate;
            ListOfItems = listOfItems;
        }
    }
}
