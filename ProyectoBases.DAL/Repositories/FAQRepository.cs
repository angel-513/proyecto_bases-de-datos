using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class FAQRepository : IGenericRepository<Faq>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public FAQRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(Faq modelo)
        {
            _dbContext.Faqs.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Faq FaqEliminar = _dbContext.Faqs.First(Faq => Faq.Faqid == id);
            _dbContext.Faqs.Remove(FaqEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Faq modelo)
        {
            _dbContext.Faqs.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Faq> Obtener(int id)
        {
            return await _dbContext.Faqs.FindAsync(id);
        }

        public async Task<IQueryable<Faq>> ObtenerTodos()
        {
            IQueryable<Faq> queryFaqesSQL = _dbContext.Faqs;
            return queryFaqesSQL;
        }
    }
}