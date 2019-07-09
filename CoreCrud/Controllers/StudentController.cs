using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoreCrud.Models;

namespace CoreCrud.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentContext _context;

        public StudentController(StudentContext context)
        {
            _context = context;
        }

        // GET: Student
        public async Task<IActionResult> Index()
        {
            return View(await _context.Students.ToListAsync());
        }

      

        // GET: Student/Create
        public IActionResult AddOrEdit(int id=0)
        {
            if(id==0)
            return View(new Student());
            else
            {
                return View(_context.Students.Find(id));
            }
        }

        // POST: Student/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("StudentId,FullName,StudentCode,StudentYear,CampusLocation")] Student student)
        {
            if (ModelState.IsValid)
            {
                if (student.StudentId == 0)
                    _context.Add((student));
                else
                _context.Update(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        

        // GET: Student/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var student = await _context.Students.FindAsync((id));
            _context.Students.Remove((student));
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

      
        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.StudentId == id);
        }
    }
}
