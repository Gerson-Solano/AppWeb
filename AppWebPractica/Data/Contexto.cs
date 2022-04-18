using Microsoft.EntityFrameworkCore;

namespace AppWebPractica.Data
{
    public class Contexto : DbContext
    {
        //Constructor por parametro 
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        //Creción del DBSet para el objeto Empleados
        public DbSet<Models.Empleados> Empleados { get; set; }
    }
}
