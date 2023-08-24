
namespace core.Entities;

public class Pais : BaseEntityA
{
    public int Id {get; set;}
    public string ? NombrePais {get;set;} 
    public ICollection<Estado> Estados {get; set;}
}
