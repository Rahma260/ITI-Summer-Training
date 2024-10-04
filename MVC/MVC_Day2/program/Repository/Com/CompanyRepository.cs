using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using program.Models.Context;
using program.Models.Entities;

namespace program.Repository.Com
{
    public class CompanyRepository : ICompanyRepository
    {
        CompanyContext context;
        public CompanyRepository(CompanyContext _companyContext)
        {
            context = _companyContext;
        }

        public List<Company> GetAllC()
        {
            return context.companies.Include(e => e.Employees).ToList();
        }
        public Company GetByIdc(int id)
        {
            return context.companies.Include(e => e.Employees).FirstOrDefault(e => e.CompanyId == id);
        }
        public void Create(Company company)
        {
            Company com = new Company();
            com.CompanyName = company.CompanyName;
            com.CompanyType = company.CompanyType;
            com.CompanyStartDate = company.CompanyStartDate;
            com.CompanyAddress = company.CompanyAddress;
            context.companies.Add(company);
            context.SaveChanges();
        }
        public void Edit(int id, Company company1)
        {
            Company companyid = context.companies.FirstOrDefault(e => e.CompanyId == id);
            companyid.CompanyName = company1.CompanyName;
            companyid.CompanyType = company1.CompanyType;
            companyid.CompanyStartDate = company1.CompanyStartDate;
            companyid.CompanyAddress = company1.CompanyAddress;
            context.companies.Update(companyid);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var companyToDelete = context.companies.FirstOrDefault(c => c.CompanyId == id);
            context.companies.Remove(companyToDelete);
            context.SaveChanges();
        }

    }
}
