using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using program.Models.Context;
using program.Models.Entities;
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Numerics;
using program.Repository.Emp;

namespace program.Controllers.EntitiesController
{
    public class EmployeeController : Controller
    {
        IEmployeeRepository emp1;
        CompanyContext context;
        public EmployeeController(IEmployeeRepository _emp, CompanyContext context)
        {
            emp1 = _emp;
            this.context = context;

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var allEmployees = emp1.GetAll();
            return View("GetAll", allEmployees);
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var employees = emp1.GetById(id);
            return View(employees);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["ListOfCompanies"] = context.companies.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            try
            {
                if (ModelState.IsValid == true)
                {
                    emp1.Create(employee);
                    return RedirectToAction("GetAll");

                }
            }

            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return RedirectToAction("Create");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee employee = context.employees.Include(c => c.Company).FirstOrDefault(e => e.EmployeeId == id);
            ViewBag.Company = context.companies.ToList();
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(int id, Employee employee)
        {
            emp1.Edit(id, employee);

            return RedirectToAction("GetAll", new { id = employee.EmployeeId });
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            emp1.Delete(id);
            return RedirectToAction("GetAll");
        }
    }
    //public class EmployeeController : Controller
    //{
    //    CompanyContext context;
    //    public EmployeeController(CompanyContext context)
    //    {
    //        student1 = _student;
    //        this.context = context;

    //    }
    //    [HttpGet]
    //    public IActionResult GetAll()
    //    {
    //        var allemps = context.employees.Include(e => e.Company).ToList();
    //        return View("GetAll", allemps);
    //    }

    //    [HttpGet]
    //    public IActionResult GetById(int id)
    //    {
    //        var employees = context.employees.Include(e => e.Company).FirstOrDefault(e => e.EmployeeId == id);
    //        return View(employees);
    //    }
    //    [HttpGet]
    //    public IActionResult Create()
    //    {
    //        ViewData["ListOfCompanies"] = context.companies.ToList();
    //        return View();
    //    }
    //    [HttpPost]
    //    public IActionResult Create(Employee employee)
    //    {
    //        Employee emp = new Employee();
    //        emp.EmployeeName = employee.EmployeeName;
    //        emp.EmployeeAge = employee.EmployeeAge;
    //        emp.EmployeeSalary = employee.EmployeeSalary;
    //        emp.EmployeeAddress = employee.EmployeeAddress;
    //        emp.EmployeeEmail = employee.EmployeeEmail;
    //        emp.EmployeePhone = employee.EmployeePhone;
    //        emp.EmployeeImage = employee.EmployeeImage;
    //        emp.CompanyId = employee.CompanyId;
    //        context.employees.Add(emp);
    //        context.SaveChanges();
    //        return RedirectToAction("GetAll");
    //    }
    //    [HttpGet]
    //    public IActionResult Edit(int id)
    //    {
    //        Employee employee = context.employees.Include(c => c.Company).FirstOrDefault(e => e.EmployeeId == id);
    //        ViewBag.Company = context.companies.ToList();
    //        return View(employee);
    //    }

    //    [HttpPost]
    //    public IActionResult Edit(int id, Employee employee)
    //    {
    //        Employee employeeToUpdate = context.employees.Include(c => c.Company).FirstOrDefault(e => e.EmployeeId == id);
    //        employeeToUpdate.EmployeeName = employee.EmployeeName;
    //        employeeToUpdate.EmployeeAge = employee.EmployeeAge;
    //        employeeToUpdate.EmployeeAddress = employee.EmployeeAddress;
    //        employeeToUpdate.EmployeeEmail = employee.EmployeeEmail;
    //        employeeToUpdate.EmployeePhone = employee.EmployeePhone;
    //        employeeToUpdate.EmployeeImage = employee.EmployeeImage;
    //        employeeToUpdate.CompanyId = employee.CompanyId;
    //        context.employees.Update(employeeToUpdate);
    //        context.SaveChanges();

    //        return RedirectToAction("GetAll", new { id = employee.EmployeeId });
    //    }
    //    [HttpPost]
    //    public IActionResult Delete(int id)
    //    {
    //        var employeeToDelete = context.employees.FirstOrDefault(e => e.EmployeeId == id);
    //        context.employees.Remove(employeeToDelete);
    //        context.SaveChanges();
    //        return RedirectToAction("GetAll");
    //    }



    //}
}
