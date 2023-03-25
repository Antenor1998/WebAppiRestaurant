using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppiRestaurant.Infrastructure.Perisistence;
public class ApplicationDbcontext : DbContext {
      public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options) {
      }
}