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
    public class VarRepoContext : DbContext//DbContext is for Entity connecting to Db;  it's the application context
    {
        public virtual DbSet<Constant> Constants { get; set; }      
    }
}