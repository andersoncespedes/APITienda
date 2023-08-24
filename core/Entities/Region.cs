
namespace core.Entities;

public class Region : BaseEntityA
{
    public string ? NombreRegion {get; set;}
    public int ? IdEstadoFk {get; set;}
    public Estado Estado {get; set;}  
}
