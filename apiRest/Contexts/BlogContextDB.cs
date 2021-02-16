using apiRest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiRest.Contexts
{
    public class BlogContextDB:DbContext
    {
        public BlogContextDB(DbContextOptions<BlogContextDB> options):base(options)
        {

        }
        public DbSet<Publicacion> Publicaciones{ set; get; }
    }
}
