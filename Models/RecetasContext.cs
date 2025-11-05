using System.Data.Entity;

namespace RecetasMVC_Project.Models
{
    public class RecetasContext : DbContext
    {
        // El nombre de la connectionString en Web.config -> "RecetasContext"
        public RecetasContext() : base("name=RecetasContext")
        {
        }

        public DbSet<Receta> Recetas { get; set; }
    }
}
