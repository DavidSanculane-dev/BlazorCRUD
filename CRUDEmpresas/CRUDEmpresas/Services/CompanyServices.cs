using CRUDEmpresas.Data;
using CRUDEmpresas.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDEmpresas.Services
{
    public class CompanyServices : ICompanyService
    {

        private readonly AppDBContext dBContext;

        public CompanyServices(AppDBContext appDBContext)
        {
            dBContext = appDBContext;
        }

        public async Task Add(Company company)
        {
            await dBContext.AddAsync(company);
            await dBContext.SaveChangesAsync();
        }

        public async Task Update(Company company)
        {
            dBContext.Update(company);
            await dBContext.SaveChangesAsync();
        }
        public async Task Remove(Company company)
        {
            dBContext.Remove(company);
            await dBContext.SaveChangesAsync();
        }

        public async Task<Company> GetById(Guid id)
        {
            var company = await dBContext.Empresas.FirstOrDefaultAsync(c => c.Id == id);
            return company;
        }

        public async Task<List<Company>> FindAll()
        {
            var companies = await dBContext.Empresas.ToListAsync();
            
            return companies;
            
        }
    }
}
