//@CodeCopy

using AddressBuch.Contracts;

namespace AddressBuch.Logic.Entities
{
	internal abstract partial class VersionEntity : IdentityEntity, IVersionable
	{
		public byte[] RowVersion { get; set; }
	}
}
