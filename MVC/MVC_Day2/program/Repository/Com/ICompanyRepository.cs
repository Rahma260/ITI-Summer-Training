using program.Models.Entities;

namespace program.Repository.Com
{
    public interface ICompanyRepository
    {
        public List<Company> GetAllC();
        public Company GetByIdc(int id);
        public void Create(Company company);
        public void Edit(int id, Company company);
        public void Delete(int id);
    }
}
