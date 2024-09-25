using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orixa.Infra;

internal class OrixaDbContext : DbContext
{


    DbSet<Orixa>Orixas { get; set; }
}
