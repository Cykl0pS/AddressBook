//@CodeCopy
using CommonBase.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientContracts = AddressBuch.Contracts.Client;

namespace AddressBuch.Logic
{
	public static partial class Factory
	{
		private static Contracts.IContext CreateContext()
		{
			return new DataContext.ProjectDbContext();
		}
		public static ClientContracts.IControllerAccess<C> Create<C>()
			where C : AddressBuch.Contracts.IIdentifiable
		{
			ClientContracts.IControllerAccess<C> result = null;

			CreateController<C>(CreateContext(), ref result);
			return result;
		}
		static partial void CreateController<C>(Contracts.IContext context, ref ClientContracts.IControllerAccess<C> controller) 
			where C : AddressBuch.Contracts.IIdentifiable;
		public static ClientContracts.IControllerAccess<C> Create<C>(object controller)
			where C : AddressBuch.Contracts.IIdentifiable
		{
			var controllerObject = controller as Controllers.ControllerObject;

			controllerObject.CheckArgument(nameof(controller));

			ClientContracts.IControllerAccess<C> result = null;

			CreateController<C>(controllerObject, ref result);
			return result;
		}
		static partial void CreateController<C>(Controllers.ControllerObject controllerObject, ref ClientContracts.IControllerAccess<C> controller)
			where C : AddressBuch.Contracts.IIdentifiable;
	}
}
