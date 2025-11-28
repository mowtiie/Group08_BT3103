using Saleling.Model;
using Saleling.Repository;

namespace Saleling.Controller
{
    public class CustomerController
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerController()
        {
            _customerRepository = new CustomerRepository();
        }

        public async Task<CustomerModel> GetWalkInCustomerAsync()
        {
            CustomerModel? walkInCustomer = await _customerRepository.GetWalkInCustomerAsync();
            if (walkInCustomer == null)
            {
                throw new InvalidOperationException("Walk-in customer record not found in the database.");
            }

            return walkInCustomer;
        }
    }
}
