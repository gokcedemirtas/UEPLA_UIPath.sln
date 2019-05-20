using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Uepla
{
    public class FormContext : DbContext
    {
        public FormContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Form> MyForm { get; set; }
    }
}
