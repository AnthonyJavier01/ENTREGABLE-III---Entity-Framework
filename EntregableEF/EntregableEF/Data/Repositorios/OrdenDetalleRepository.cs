using Dapper;
using EntregableEF.Modelos;
using Microsoft.EntityFrameworkCore;


namespace EntregableEF.Data.Repositorios
{
    public class OrdenDetalleRepository
    : RepositoryBase<OrdenDetalle>
    {
        public OrdenDetalleRepository(
        ApplicationDbContext context)
        : base(context)
        {
        }

        public override OrdenDetalle GetById(int id)
        {
            return _context.OrdenDetalle
            .AsNoTracking()
            .FirstOrDefault(x =>
            x.DetalleId == id &&
            x.Deleted == null)!;
        }

        public void DeleteByOrdenId(int ordenId)
        {
            var detalles = _context.OrdenDetalle
            .Where(x =>
            x.OrdenId == ordenId &&
            x.Deleted == null)
            .ToList();

            foreach (var detalle in detalles)
            {
                detalle.Deleted = DateTime.Now;
                detalle.Updated = DateTime.Now;
            }

            _context.SaveChanges();
        }
    }
}
