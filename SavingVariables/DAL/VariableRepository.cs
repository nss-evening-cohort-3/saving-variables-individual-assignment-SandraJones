using SavingVariables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SavingVariables.DAL
{
    public class VariableRepository
    {
        //mock and context
        private object context;
        private object constants;

        public VariableRepository()
        {
            VariableRepository repo = new VariableRepository();
        }
        public VarRepoContext mock_context { get; set; }
        public VariableRepository(VarRepoContext _context)
        {
            mock_context = _context;
        }
        //GET THE CONSTANT from mock db
        //public List<Constants> GetMyConstant()
        //{
        //    //search mock DB for constant
        //    return Context.Constants(char key);
        //}  
    }
}