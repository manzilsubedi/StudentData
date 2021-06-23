using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentContext _db;
        public StudentController(StudentContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            var stdlist = _db.StudentData.ToList();
            return View(stdlist);
        }

       

        public IActionResult Create()
        {
            Student std = new Student();
          
            return View(std);
        }

        public IActionResult AddStudents(Student std)
        {
            _db.StudentData.Add(std);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Edit(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.StudentData.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        [HttpPost]
        public IActionResult Edit(Student std)
        {
            _db.Update(std);
            _db.Entry(std).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.StudentData.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        [HttpPost]
        public IActionResult Delete(Student std)
        {
            _db.Remove(std);
            _db.Entry(std).State = EntityState.Deleted;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}
