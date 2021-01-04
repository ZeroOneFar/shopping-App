namespace ACM.BL
{
    public enum AddressType{Home,Work,Office}
    public class Address
    {
        public Address(int addressId)
        {
            AddressId = addressId;
        }
        public int AddressId { get; private set; }
        public int? PostalCodeOrZipCode { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string Country { get; set; }
        public AddressType AddressType { get; set; }

        public bool Validate()
        {
            return (!string.IsNullOrWhiteSpace(StreetLine1) || !string.IsNullOrWhiteSpace(StreetLine2))
                   && PostalCodeOrZipCode != null;
        }
    }
}