using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using program.Models.Context;
using program.Models.Entities;
using program.Repository.Com;
using program.Repository.Emp;
using System.Data;

namespace program.Controllers.EntitiesController
{
    public class CompanyController : Controller
    {
        ICompanyRepository com;
        CompanyContext context;
        public CompanyController(ICompanyRepository company, CompanyContext context)
        {
            com = company;
            this.context = context;

        }
        [HttpGet]
        public IActionResult GetAllC()
        {
            var allcompanies = com.GetAllC();
            return View("GetAllC", allcompanies);
        }
        [HttpGet]
        public IActionResult GetByIdc(int id)
        {
            var companies = com.GetByIdc(id);
            return View(companies);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Company company)
        {

            try
            {
                if (ModelState.IsValid == true)
                {
                   com.Create(company);
                    return RedirectToAction("GetAllC");

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
            var company = context.companies.Include(c => c.Employees).FirstOrDefault(e => e.CompanyId == id);

            return View(company);
        }
        [HttpPost]
        public IActionResult Edit(int id, Company company1)
        {
            com.Edit(id, company1);
            return RedirectToAction("GetAllC", new { id = company1.CompanyId });
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            com.Delete(id);
            return RedirectToAction("GetAllC");
        }


    }
    //public class CompanyController : Controller
    //{

    //    CompanyContext context;
    //    public CompanyController(CompanyContext context)
    //    {
    //        this.context = context;

    //    }

    //    public IActionResult GetAllC()
    //    {
    //        var allcompanies = context.companies.Include(e => e.Employees).ToList();
    //        return View("GetAllC", allcompanies);
    //    }

    //    public IActionResult GetByIdc(int id)
    //    {
    //        var companies = context.companies.Include(e => e.Employees).FirstOrDefault(e => e.CompanyId == id);
    //        return View(companies);
    //    }
    //    [HttpGet]
    //    public IActionResult Create()
    //    {
    //        return View();
    //    }
    //    [HttpPost]
    //    public IActionResult Create(string CompanyName, string CompanyType, string CompanyStartDate, string CompanyAddress)
    //    {
    //        Company company = new Company();
    //        company.CompanyName = CompanyName;
    //        company.CompanyType = CompanyType;
    //        company.CompanyStartDate = CompanyStartDate;
    //        company.CompanyAddress = CompanyAddress;
    //        context.companies.Add(company);
    //        context.SaveChanges();
    //        return RedirectToAction("GetAllC");
    //    }
    //    [HttpGet]
    //    public IActionResult Edit(int id)
    //    {
    //        var company = context.companies.Include(c => c.Employees).FirstOrDefault(e => e.CompanyId == id);

    //        return View(company);
    //    }
    //    [HttpPost]
    //    public IActionResult Edit(int id, Company company1)
    //    {
    //        Company companyid = context.companies.FirstOrDefault(e => e.CompanyId == id);
    //        companyid.CompanyName = company1.CompanyName;
    //        companyid.CompanyType = company1.CompanyType;
    //        companyid.CompanyStartDate = company1.CompanyStartDate;
    //        companyid.CompanyAddress = company1.CompanyAddress;
    //        context.companies.Update(companyid);
    //        context.SaveChanges();

    //        return RedirectToAction("GetAllC", new { id = company1.CompanyId });
    //    }
    //    [HttpPost]
    //    public IActionResult Delete(int id)
    //    {
    //        var companyToDelete = context.companies.FirstOrDefault(c => c.CompanyId == id);
    //        context.companies.Remove(companyToDelete);
    //        context.SaveChanges();
    //        return RedirectToAction("GetAllC");
    //    }


    //}
}
