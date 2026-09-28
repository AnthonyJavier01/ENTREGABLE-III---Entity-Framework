
using EntregableEF.Modelos;
using Microsoft.EntityFrameworkCore;


namespace EntregableEF.Data.Repositorios
{
    public class ClientesRepository
 : RepositoryBase<Clientes>
    {
        public ClientesRepository(ApplicationDbContext context)
        : base(context)
        {
        }

        public override Clientes GetById(int id)
        {
            return _context.Clientes
            .AsNoTracking()
            .FirstOrDefault(x =>
            x.ClienteId == id &&
            x.Deleted == null)!;
        }
    }
}
