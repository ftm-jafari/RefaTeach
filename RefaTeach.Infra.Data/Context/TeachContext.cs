using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RefaTeach.Infra.Data.Context
{
    public class TeachContext : DbContext
    {
        #region Constructor

        public TeachContext(DbContextOptions<TeachContext> options):base(options)
        {
            
        }

        #endregion
    }
}
