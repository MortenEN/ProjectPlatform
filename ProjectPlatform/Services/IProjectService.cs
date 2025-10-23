using ProjectPlatform.Model;

namespace ProjectPlatform.Services
{
    public interface IProjectService
    {
        public IEnumerable<Item> GetAllItems();
        public Item GetItem();
        public bool Delete();
        public bool Update();
    }
}
