//@CodeCopy

namespace AddressBuch.Contracts
{
	public partial interface IVersionable : IIdentifiable
	{
		byte[] RowVersion { get; }
	}
}
