using AddressBuch.Contracts.Persistence.AddressBuecher;
using AddressBuch.Transfer.Models.Persistence.AddressBuecher;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBuch.WebApi.Controllers.Persistence
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class AddressBookController : GenericController<IAddressBook, AddressBook>
    {
    }
}
