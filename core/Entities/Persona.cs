using System.Collections.Generic;

namespace core.Entities;

public class Persona : BaseEntityA
{
    public string IdPersona {get; set;}
    public string NombrePersona {get;set;} 
    public DateTime FechaNac {get; set;}      
    public int IdTipoPerFk {get; set;}
    public TipoPersona TipoPersona {get; set;}
    public ICollection<ProductoPersona> ProductosPersonas {get; set;} 
}
