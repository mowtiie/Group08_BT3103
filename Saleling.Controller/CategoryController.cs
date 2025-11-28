using Saleling.Repository;

namespace Saleling.Controller
{
    public class CategoryController
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryController()
        {
            _categoryRepository = new CategoryRepository();
        }

        public async Task<List<string>> GetAllNamesAsync()
        {
            return await _categoryRepository.GetAllNamesAsync();
        }

        public async Task<int> GetTotalCountAsync()
        {
            return await _categoryRepository.GetTotalCountAsync();
        }
    }
}
