using ProjectPlatform.Model;

namespace ProjectPlatform.Services
{
    public interface IUserService
    {
        public IEnumerable<Project> GetAllProjects();
        public IEnumerable<Project> GetAllCompletedProject();
        public IEnumerable<Project> GetAllNonCompletedProjects();
        public Project GetProject();
        public bool Delete();
        public bool Update();
    }
}
