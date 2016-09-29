using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Runtime.Remoting.Contexts;
using SavingVariables.DAL;
using SavingVariables.Models;
using Moq;

namespace SavingVariables.Tests.DAL
{
    [TestClass]
    public class VariableRepositoryTests
    {

        private List<Constant> constants_list;
        private Mock<DbSet<Constant>> mock_constants_table;
        private Mock<VarRepoContext> mock_context;
        private object constant;
        private object preConstantsList;

        VariableRepository repo { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            mock_context = new Mock<VarRepoContext>();
            mock_constants_table = new Mock<DbSet<Constant>>();
            constants_list = new List<Constant>();
            // repo = new VariableRepository(mock_context.Object);
        }
        [TestMethod]
        public void EnsureInstanceofRepository()
        {
            VariableRepository repository = new VariableRepository();
        }

        public void ConnectMocksToDatastore()
        {
            var queryable_list = constants_list.AsQueryable();

            // Lie to LINQ make it think that our new Queryable List is a Database table.
            mock_constants_table.As<IQueryable<Constant>>().Setup(m => m.Provider).Returns(queryable_list.Provider);
            mock_constants_table.As<IQueryable<Constant>>().Setup(m => m.Expression).Returns(queryable_list.Expression);
            mock_constants_table.As<IQueryable<Constant>>().Setup(m => m.ElementType).Returns(queryable_list.ElementType);
            mock_constants_table.As<IQueryable<Constant>>().Setup(m => m.GetEnumerator()).Returns(() => queryable_list.GetEnumerator());

            // Have our Author property return our Queryable List AKA Fake database table.
            mock_context.Setup(t => t.Constants).Returns(mock_constants_table.Object);
            mock_constants_table.Setup(t => t.Add(It.IsAny<Constant>())).Callback((Constant a) => constants_list.Add(a));
            mock_constants_table.Setup(t => t.Remove(It.IsAny<Constant>())).Callback((Constant a) => constants_list.Remove(a));
        }


        [TestMethod]
        public void RepoEnsureCanCreateInstanceOfMock()
        {
            mock_context = new Mock<VarRepoContext>();
            Assert.IsNotNull(mock_context);
        }

        [TestMethod]
        public void EnsureTableIsEmpty()
        {
            mock_context = new Mock<VarRepoContext>();
            // repo = new VariableRepository(mock_context.Object);
            int listCount = constants_list.Count;//repo.GetConstants().Count;//returns a list
            Assert.AreEqual(listCount, 0);
        }

        public List<Constant> GetConstants()
        {
            return constants_list.ToList();
        }

        [TestMethod]
        //search mock DB for constant
        public void EnsureGetConstantsWorks()
        {
            GetConstants();
            Assert.AreEqual(constants_list.Count, 0);
        }
     
        //the next two tests do not work

        [TestMethod]
        public void AddConstant()//_ means private or local//taking out parameters, Constant mock_const
        {
            Constant my_constant = new Constant();
            constants_list.Add(my_constant);
            Assert.AreNotEqual(constants_list, 0);
           //mock_context.SaveChanges();
        }

        [TestMethod]      
        public void TestRemoveConstant()
        {
            Constant my_constant = new Constant();
            constants_list.Remove(my_constant);
            Assert.AreEqual(constants_list.Count, 0);
        }

        [TestMethod]
        public void TestFindConstantbyKey()
        {
            Constant my_constant = new Constant();
            string key = null;
            constants_list.FirstOrDefault(c => c.Key == key);//for each row c of database look for key; c.Key is column value in that row;column name is Key
            Assert.AreEqual(null, key);

        }        
    }
}



