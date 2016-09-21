using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingVariables.DAL
{
    class VariableRepository
    {
        public VarRepoContext mock_context { get; }

        public VariableRepository(VarRepoContext _context)
        {
            mock_context = _context;
        }

        public VariableRepository()
        {
        }
    }
}
