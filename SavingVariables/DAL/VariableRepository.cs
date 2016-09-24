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
        //Context is to connect to Db; mock_context is to connect to mock Db
        public VarRepoContext Context { get; set; }
        public VariableRepository()
        {
            Context = new VarRepoContext();
        }
        public VarRepoContext mock_context { get; set; }
        public VariableRepository(VarRepoContext _context)
        {
            Context = _context;
        }
        //GET THE CONSTANT from mock db
        public List<Constant> GetConstants()
        {
            int i = 1;
           //search mock DB for constant
            return Context.Constants.ToList();
        }
        public void AddConstant(Constant _constant)//_ means private or local
        {
            Context.Constants.Add(_constant);
            Context.SaveChanges();
        }
        public Constant FindConstantbyKey(string key)
        {
            return Context.Constants.FirstOrDefault(c => c.Key == key);//for each row c of database look for key; c.Key is column value in that row;column name is Key
            
        }
        public Constant RemoveConstants(string key)
        {
            Constant found_constant = FindConstantbyKey(key);
            if (found_constant != null)
            {
                Context.Constants.Remove(found_constant);
                Context.SaveChanges();
            }
            return found_constant;
        }
    }
}