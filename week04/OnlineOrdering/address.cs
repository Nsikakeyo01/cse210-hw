// Author: Nsikak Eyo
// Location: Uyo, Akwa Ibom State, Nigeria
// Represents a customer's address

namespace NsikakOrdering
{
    public class CustomerAddress
    {
        private string _street;
        private string _city;
        private string _stateOrProvince;
        private string _country;

        public CustomerAddress(string street, string city, string stateOrProvince, string country)
        {
            _street = street;
            _city = city;
            _stateOrProvince = stateOrProvince;
            _country = country;
        }

        public string FullAddress()
        {
            return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
        }

        public bool IsInUSA()
        {
            return _country.ToUpper() == "USA";
        }
    }
}
