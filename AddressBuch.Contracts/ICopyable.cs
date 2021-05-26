//@CodeCopy

namespace AddressBuch.Contracts
{
	public partial interface ICopyable<T>
	{
		void CopyProperties(T other);
	}
}
