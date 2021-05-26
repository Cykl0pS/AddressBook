using AddressBuch.Contracts.Client;
using AddressBuch.Contracts.Persistence.AddressBuecher;

namespace AddressBuch.Logic
{
    partial class Factory
    {
        static partial void CreateController<C>(Contracts.IContext context, ref IControllerAccess<C> controller)
            where C : AddressBuch.Contracts.IIdentifiable
        {
            if (typeof(C) == typeof(IAddressBook))
            {
                controller = new Controllers.Persistence.AddressBuecher.AddressBuchController(context) as IControllerAccess<C>;
            }
        }

        static partial void CreateController<C>(Controllers.ControllerObject controllerObject, ref IControllerAccess<C> controller)
            where C : AddressBuch.Contracts.IIdentifiable
        {
            if (typeof(C) == typeof(IAddressBook))
            {
                controller = new Controllers.Persistence.AddressBuecher.AddressBuchController(controllerObject) as IControllerAccess<C>;
            }
        }
    }
}
