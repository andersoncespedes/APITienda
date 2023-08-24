using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace infrastructure.Repository;

    public class PaisRepository : GenericRepositoryA<Pais>, IPaisInterface
    {
        public PaisRepository(InventarioContext context) : base(context){
            _context = context;
        }
        public override async Task<IEnumerable<Pais>> GetAllAsync(){
            return await _context.Paises.Include(p => p.Estados).ToListAsync();
        }
        public override async Task<Pais> getByIdAsync(string id){
            return await _context.Paises.Include(p => e.Estados).FirstOrDefaultAsync(p.Id == id);
        }
    }
