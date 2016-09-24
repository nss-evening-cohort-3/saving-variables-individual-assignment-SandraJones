using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
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


        [TestInitialize]
        public void Initialize()
        {
            mock_context = new Mock<VarRepoContext>();
            mock_constants_table = new Mock<DbSet<Constant>>();
            constants_list = new List<Constant>();
        }
        [TestMethod]
        public void RepoEnsureCanCreateInstanceOfMock()
        {
            Assert.IsNotNull(mock_context);
        }
    }  
}
