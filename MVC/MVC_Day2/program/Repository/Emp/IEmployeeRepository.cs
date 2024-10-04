using program.Models.Entities;

namespace program.Repository.Emp
{
    public interface IEmployeeRepository
    {
        public List<Employee> GetAll();
        public Employee GetById(int id);
        public void Create(Employee employee);
        public void Edit(int id, Employee employee);
        public void Delete(int id);

    }
}
