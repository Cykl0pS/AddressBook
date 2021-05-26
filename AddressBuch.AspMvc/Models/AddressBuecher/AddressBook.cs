using AddressBuch.Contracts.Persistence.AddressBuecher;
using CommonBase.Extensions;

namespace AddressBuch.AspMvc.Models.AddressBuecher
{
    public partial class AddressBook : VersionModel, IAddressBook
    {
        public string Name { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        public void CopyProperties(IAddressBook other)
        {
            other.CheckArgument(nameof(other));

            Id = other.Id;
            RowVersion = other.RowVersion;
            Name = other.Name;
            PostalCode = other.PostalCode;
            City = other.City;
            Address = other.Address;
        }
    }
}
