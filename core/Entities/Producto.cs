using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Entities;

public class Producto : BaseEntityA
{
    public string CodInterno {get; set;}
    public string Nombre {get; set;}
    public int StockMin {get; set;}
    public int StockMax {get; set;}
    public int Stock {get; set;}     
    public double ValorVta {get; set;}     
    public ICollection<ProductoPersona> ProductosPersonas {get; set;} 
}
