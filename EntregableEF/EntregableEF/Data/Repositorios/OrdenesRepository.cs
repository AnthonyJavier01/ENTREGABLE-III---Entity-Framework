using Dapper;
using EntregableEF.Modelos;
using Microsoft.EntityFrameworkCore;

namespace EntregableEF.Data.Repositorios
{
    public class OrdenesRepository
    : RepositoryBase<Ordenes>
    {
        public OrdenesRepository(ApplicationDbContext context)
        : base(context)
        {
        }

        public override Ordenes GetById(int id)
        {
            return _context.Ordenes
            .AsNoTracking()
            .FirstOrDefault(x =>
            x.OrdenId == id &&
            x.Deleted == null)!;
        }
    }
}
