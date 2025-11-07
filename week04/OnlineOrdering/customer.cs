// Author: Nsikak Eyo
// Location: Uyo, Akwa Ibom State, Nigeria
// Represents a customer with name and address

namespace NsikakOrdering
{
    public class Customer
    {
        private string _customerName;
        private CustomerAddress _customerAddress;

        public Customer(string customerName, CustomerAddress customerAddress)
        {
            _customerName = customerName;
            _customerAddress = customerAddress;
        }

        public string Name { get { return _customerName; } }
        public CustomerAddress Address { get { return _customerAddress; } }

        public bool LivesInUSA()
        {
            return _customerAddress.IsInUSA();
        }
    }
}
