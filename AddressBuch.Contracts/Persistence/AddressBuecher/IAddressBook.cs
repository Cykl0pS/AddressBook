using CommonBase.Attributes;

namespace AddressBuch.Contracts.Persistence.AddressBuecher
{
    [ContractInfo(ContextType = ContextType.Table)]
    public partial interface IAddressBook : IVersionable, ICopyable<IAddressBook>
    {
        [ContractPropertyInfo(Required = true, MaxLength = 128)]
        public string Name { get; set; }

        [ContractPropertyInfo(Required = true)]
        public int PostalCode { get; set; }

        [ContractPropertyInfo(Required = true, MaxLength = 128)]
        public string City { get; set; }

        [ContractPropertyInfo(Required = true, MaxLength = 256)]
        public string Address { get; set; }
    }
}
