using Dapper;
using EntregableEF.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntregableEF.Data.Repositorios
{
    public class CategoriasRepository
    : RepositoryBase<Categorias>
    {
        public CategoriasRepository(ApplicationDbContext context)
        : base(context)
        {
        }

        public override Categorias GetById(int id)
        {
            return _context.Categorias
            .AsNoTracking()
            .FirstOrDefault(x =>
            x.CategoriaId == id &&
            x.Deleted == null)!;
        }
    }
}
