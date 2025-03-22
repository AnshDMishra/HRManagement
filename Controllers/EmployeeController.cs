using HRManagement.Data;
using HRManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly HRManagementDbContext db;

        public EmployeeController(HRManagementDbContext context)
        {
            this.db = context;      
        }
        [HttpGet]
        public async Task <IActionResult> Index()
        {
            var Employees = await db.Employees.Include(e => e.Department).ToListAsync();
                
            return View(Employees);
        }
        [HttpGet]
        public async Task<IActionResult> Create() 
        { 
            ViewBag.Departments = await db.Departments.ToListAsync();
            return View();  
        }
        [HttpPost]
        public async Task<IActionResult> Save(Employee obj)
         {
            if (!ModelState.IsValid)
            {
                ViewBag.Departments = await db.Departments.ToListAsync();
                return View(obj);
            }
            db.Employees.Add(obj);
            await db.SaveChangesAsync();
            TempData["Success"] = "Employee Added Successfuly!";
            return  RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var Employee = await db.Employees
                                   .Include(e => e.Department)
                                   .FirstOrDefaultAsync(e => e.Emp_ID == id);
            if(Employee==null)
            {
                return NotFound();
            }
            return View(Employee);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Employee = await db.Employees
                                   .Include(e => e.Department)
                                   .FirstOrDefaultAsync(e => e.Emp_ID == id);
            if (Employee == null)
            {
                return NotFound();
            }
            return View(Employee);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var employee = await db.Employees.FindAsync(id);
            if(employee == null)
            {
                return NotFound("Details Not Found");
            }
            db.Employees.Remove(employee);
            await db.SaveChangesAsync();
            TempData["Success"] = "Employee Deleted Successfuly!";
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.Departments = await db.Departments.ToListAsync();
            if (id == null)
            {
                return NotFound();
            }
            var Employee = await db.Employees
                                   .Include(e => e.Department)
                                   .FirstOrDefaultAsync(e => e.Emp_ID == id);
            if (Employee == null)
            {
                return NotFound();
            }
            return View(Employee);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Employee Obj)
        {
            if (ModelState.IsValid)
            { 
                db.Employees.Update(Obj);
                await db.SaveChangesAsync();
                TempData["Success"] = "Employee Updated Successfuly!";
                return RedirectToAction("Index");
            }
            return View(Obj);
        }
    }
}
 