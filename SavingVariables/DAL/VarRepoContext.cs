using System;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web;
using SavingVariables.Models;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;

namespace SavingVariables.DAL
{
    public class VarRepoContext : DbContext
    {
        public virtual DbSet<Constants> Constants { get; set; }
        
    }
}