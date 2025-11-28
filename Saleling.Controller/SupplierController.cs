using Saleling.Repository;

namespace Saleling.Controller
{
    public class SupplierController
    {
        private readonly SupplierRepository _supplierRepository;
        public SupplierController()
        {
            _supplierRepository = new SupplierRepository();
        }
        public async Task<List<string>> GetAllNamesAsync()
        {
            return await _supplierRepository.GetAllNamesAsync();
        }
    }
}
