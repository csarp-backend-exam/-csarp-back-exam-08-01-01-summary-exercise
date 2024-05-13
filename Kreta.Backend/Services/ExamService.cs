using Kreta.Backend.Repos.Managers;

namespace Kreta.Backend.Services
{
    public class ExamService : IExamService
    {
        private readonly IRepositoryManager _repositoryManager;
        public ExamService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
    }
}
