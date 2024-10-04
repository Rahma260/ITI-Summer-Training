using Microsoft.EntityFrameworkCore;
using program.Models.Context;
using program.Models.Entities;

namespace program.Repository.Emp
{
    public class EmployeeRepository : IEmployeeRepository
    {
        CompanyContext context;
        public EmployeeRepository(CompanyContext _companyContext)
        {
            context = _companyContext;
        }
        public List<Employee> GetAll()
        {
            return context.employees.Include(e => e.Company).ToList();

        }
        public Employee GetById(int id)
        {
            return context.employees.Include(e => e.Company).FirstOrDefault(e => e.EmployeeId == id);
        }
        public void Create(Employee employee)
        {
            Employee emp = new Employee();
            emp.EmployeeName = employee.EmployeeName;
            emp.EmployeeAge = employee.EmployeeAge;
            emp.EmployeeSalary = employee.EmployeeSalary;
            emp.EmployeeAddress = employee.EmployeeAddress;
            emp.EmployeeEmail = employee.EmployeeEmail;
            emp.EmployeePhone = employee.EmployeePhone;
            emp.EmployeeImage = employee.EmployeeImage;
            emp.CompanyId = employee.CompanyId;
            context.employees.Add(emp);
            context.SaveChanges();
        }
        public void Edit(int id, Employee employee)
        {
            Employee employeeToUpdate = GetById(id);
            employeeToUpdate.EmployeeName = employee.EmployeeName;
            employeeToUpdate.EmployeeAge = employee.EmployeeAge;
            employeeToUpdate.EmployeeAddress = employee.EmployeeAddress;
            employeeToUpdate.EmployeeEmail = employee.EmployeeEmail;
            employeeToUpdate.EmployeePhone = employee.EmployeePhone;
            employeeToUpdate.EmployeeImage = employee.EmployeeImage;
            employeeToUpdate.CompanyId = employee.CompanyId;
            context.employees.Update(employeeToUpdate);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var employeeToDelete = context.employees.FirstOrDefault(e => e.EmployeeId == id);
            context.employees.Remove(employeeToDelete);
            context.SaveChanges();

        }
    }
}