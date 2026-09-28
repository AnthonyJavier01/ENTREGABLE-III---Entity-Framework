using Dapper;
using EntregableEF.Modelos;
using Microsoft.EntityFrameworkCore;


namespace EntregableEF.Data.Repositorios
{
    public class ProductosRepository
    : RepositoryBase<Productos>
    {
        public ProductosRepository(ApplicationDbContext context)
        : base(context)
        {
        }

        public override Productos GetById(int id)
        {
            return _context.Productos
            .AsNoTracking()
            .FirstOrDefault(x =>
            x.ProductoId == id &&
            x.Deleted == null)!;
        }
    }
}
