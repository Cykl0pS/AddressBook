using AddressBuch.AspMvc.Models.AddressBuecher;
using AddressBuch.Contracts.Persistence.AddressBuecher;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBuch.AspMvc.Controllers
{
    public class AddressBookController : GenericModelController<IAddressBook, AddressBook>
    {
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            using var ctrl = Logic.Factory.Create<IAddressBook>();
            var entity = await ctrl.CreateAsync().ConfigureAwait(false);

            return View(ToModel(entity));
        }

        [HttpPost]
        public async Task<IActionResult> Insert(AddressBook model)
        {
            using var ctrl = Logic.Factory.Create<IAddressBook>();

            var entity = await ctrl.InsertAsync(model).ConfigureAwait(false);
            await ctrl.SaveChangesAsync().ConfigureAwait(false);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            using var ctrl = Logic.Factory.Create<IAddressBook>();

            var entity = await ctrl.GetByIdAsync(id).ConfigureAwait(false);

            return View(ToModel(entity));
        }

        [HttpPost]
        public async Task<IActionResult> Update(AddressBook model)
        {
            using var ctrl = Logic.Factory.Create<IAddressBook>();
            var entity = await ctrl.GetByIdAsync(model.Id).ConfigureAwait(false);

            if (entity != null)
            {
                entity.Name = model.Name;
                entity.PostalCode = model.PostalCode;
                entity.City = model.City;
                entity.Address = model.Address;

                await ctrl.UpdateAsync(entity).ConfigureAwait(false);
                await ctrl.SaveChangesAsync().ConfigureAwait(false);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            using var ctrl = Logic.Factory.Create<IAddressBook>();

            var entity = await ctrl.GetByIdAsync(id).ConfigureAwait(false);

            return View(ToModel(entity));
        }

        public async Task<IActionResult> DeleteEntity(int id)
        {
            using var ctrl = Logic.Factory.Create<IAddressBook>();

            await ctrl.DeleteAsync(id).ConfigureAwait(false);
            await ctrl.SaveChangesAsync().ConfigureAwait(false);

            return RedirectToAction("Index");
        }
    }
}
