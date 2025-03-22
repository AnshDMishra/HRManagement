using HRManagement.Data;
using HRManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HRManagement.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly HRManagementDbContext db;

        public DepartmentController(HRManagementDbContext context)
        {
            this.db = context;
        }

        // GET: Department List
        public async Task<IActionResult> Index()
        {
            var departments = await db.Departments.ToListAsync();
            return View(departments);
        }

        // GET: Create Department
        public IActionResult Create()
        {
            return View();
        }

        // POST: Create Department
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Department dept)
        {
            if (ModelState.IsValid)
            {
                await db.Departments.AddAsync(dept);
                await db.SaveChangesAsync();
                TempData["Success"] = "Department added successfully!";
                return RedirectToAction("Index");
            }
            return View(dept);
        }

        // GET: Department Details
        public async Task<IActionResult> Details(int id)
        {
            var department = await db.Departments.FindAsync(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }

        // GET: Edit Department
        public async Task<IActionResult> Edit(int id)
        {
            var department = await db.Departments.FindAsync(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }

        // POST: Edit Department
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Department dept)
        {
            if (id != dept.Dept_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                db.Departments.Update(dept);
                await db.SaveChangesAsync();
                TempData["Success"] = "Department updated successfully!";
                return RedirectToAction("Index");
            }
            return View(dept);
        }

        // GET: Delete Department
        public async Task<IActionResult> Delete(int id)
        {
            var department = await db.Departments.FindAsync(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }

        // POST: Confirm Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var department = await db.Departments.FindAsync(id);
            if (department != null)
            {
                db.Departments.Remove(department);
                await db.SaveChangesAsync();
                TempData["Success"] = "Department deleted successfully!";
            }
            return RedirectToAction("Index");
        }
    }
}
