using AddressBuch.Contracts.Persistence.AddressBuecher;
using CommonBase.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBuch.Logic.Entities.AddressBuecher
{
    partial class AddressBook : VersionEntity, IAddressBook
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
