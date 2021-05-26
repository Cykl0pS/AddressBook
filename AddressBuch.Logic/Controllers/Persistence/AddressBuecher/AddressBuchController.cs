using AddressBuch.Contracts.Persistence.AddressBuecher;
using AddressBuch.Logic.Contracts;
using AddressBuch.Logic.Entities.AddressBuecher;

namespace AddressBuch.Logic.Controllers.Persistence.AddressBuecher
{
    class AddressBuchController : GenericPersistenceController<IAddressBook, AddressBook>
    {
		public AddressBuchController(IContext context) : base(context)
		{
		}

		public AddressBuchController(ControllerObject other) : base(other)
		{
		}
	}
}
