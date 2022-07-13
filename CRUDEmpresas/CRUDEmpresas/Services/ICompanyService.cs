using CRUDEmpresas.Models;

namespace CRUDEmpresas.Services
{
    public interface ICompanyService
    {
        Task Add(Company company);

        Task Update(Company company);

        Task Remove(Company company);

        Task<Company> GetById(Guid id);

        Task<List<Company>> FindAll();

    }
}
