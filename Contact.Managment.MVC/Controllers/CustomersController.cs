using Contact.Management.Appliaction.Contracts.Persistence;
using Contact.Managment.MVC.Contracts;
using Contact.Managment.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact.Managment.MVC.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerService _customerRepository;


        public CustomersController(ICustomerService customerRepository)
        {
            _customerRepository = customerRepository;
        }
        // GET: CustomersController
        public async Task<ActionResult> Index()
        {
            var model = await _customerRepository.GetCustomers();
            return View(model);
        }

        // GET: CustomersController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var model = await _customerRepository.GetCustomerDetail(id);
            return View(model);
        }

        // GET: CustomersController/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: CustomersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreateCustomerVM  customer)
        {
            try
            {
                var response = await _customerRepository.CreateCustomer(customer);
                if (response.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", response.ValidationErrors);
            }
            catch(Exception exp)
            {
                ModelState.AddModelError("", exp.Message);
            }
            return View(customer);
        }


        // GET: CustomersController/Edit/5
        

        // GET: CustomersController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var model = await _customerRepository.GetCustomerDetail(id);
            return View(model);
        }

        // POST: CustomersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, CustomerVM customer)
        {
            try
            {
                var response = await _customerRepository.UpdateCustomer(id, customer);
                if (response.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", response.ValidationErrors);
            }
            catch (Exception exp)
            {
                ModelState.AddModelError("", exp.Message);
            }
            return View(customer);
        }

        // GET: CustomersController/Delete/5
        /* public async Task<ActionResult> Delete(int id)
         {
             return View();
         }

         // POST: CustomersController/Delete/5
         [HttpPost]
         [ValidateAntiForgeryToken]
         public async Task<ActionResult> Delete(int id, IFormCollection collection)
         {
             try
             {
                 return RedirectToAction(nameof(Index));
             }
             catch
             {
                 return View();
             }
         }*/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var response = await _customerRepository.DeleteCustomer(id);
                if (response.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", response.ValidationErrors);
            }
            catch (Exception exp)
            {
                ModelState.AddModelError("", exp.Message);
            }
            return BadRequest();
        }
    }
}
