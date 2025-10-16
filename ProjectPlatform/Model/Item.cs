namespace ProjectPlatform.Model
{
    public class Item
    {
        public Item(int id, string name, bool singleItem, DateTime startDate, DateTime? endDate = null)
        {
            Id = id;
            Name = name;
            SingleItem = singleItem;
            StartDate = startDate;
            EndDate = endDate;
        }

        public enum ItemStatus { NotAssembled = 1, Assembled = 2, Primed = 3, Painting = 4, Varnished = 5, Done = 6 }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool SingleItem { get; set; }
        public ItemStatus Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

    }
}
