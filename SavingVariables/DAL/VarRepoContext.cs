using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Remoting.Contexts;

namespace SavingVariables.DAL
{
    public class VarRepoContext: DbContext
    {
        VarRepoContext context = new VarRepoContext();
        // 'virtual' keyword is needed to use Moq during testing
        public virtual DbSet<Constants> Constants { get; set; }
    }
}