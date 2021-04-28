using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Reservando.Models
{
    public partial class DBReservandoContext: DbContext
    {
        public DBReservandoContext()
        {

        }
        public DBReservandoContext(DbContextOptions<DBReservandoContext> options) : base(options)
        {

        }
    }
}
