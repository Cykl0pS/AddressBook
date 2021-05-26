//@CodeCopy

using CommonBase.Extensions;
using AddressBuch.Contracts;

namespace AddressBuch.Logic.Entities
{
	internal abstract partial class IdentityEntity : IIdentifiable
	{
		public int Id { get; set; }
	}
}
