using Lanches.Context;
using Lanches.Models;
using Lanches.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lanches.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _Context;
        public LancheRepository(AppDbContext context)
        {
            _Context = context;
        }

        public IEnumerable<Lanche> Lanches => _Context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _Context.Lanches.
                                   Where(l => l.IsLanchePreferido).
                                   Include(c => c.Categoria);

        public Lanche GetLancheById(int id)
        {
            return _Context.Lanches.FirstOrDefault(l => l.LancheId== id);
        }
    }
}
