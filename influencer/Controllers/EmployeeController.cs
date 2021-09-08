using Domain.Contracts;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace influencer.Controllers
{
    //[Authorize(Roles = "Owner")]
    //[AllowAnonymous]
    [Authorize(Policy = "DynamicRole")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        // GET: Employee
        [AllowAnonymous]
        //[Authorize(Roles = "Admin")]
        //[Authorize(Policy = "EmployeeListPolicy")]
        // [Authorize(Policy = "ClaimOrRole")]
        //[Authorize(Policy = "ClaimRequirement")]
        public async Task<IActionResult> Index()
        {
            return View(await _employeeRepository.FindAll().ToListAsync());
        }

        // GET: Employee/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _employeeRepository.FindByCondition(m => m.Id == id).FirstOrDefaultAsync();
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,LastName,City,Gender")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                await _employeeRepository.Create(employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employee/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _employeeRepository.FindByCondition(m => m.Id == id).FirstOrDefaultAsync();
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,LastName,City,Gender")] Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _employeeRepository.Update(employee);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _employeeRepository.FindByCondition(m => m.Id == id).FirstOrDefaultAsync();
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var employee = await _employeeRepository.FindByCondition(m=>m.Id == id).FirstOrDefaultAsync();
            await _employeeRepository.Delete(employee);
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(Guid id)
        {
            return _employeeRepository.FindByCondition(e => e.Id == id).Any();
        }
    }
}
